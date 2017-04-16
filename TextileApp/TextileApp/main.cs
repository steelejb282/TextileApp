using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace TextileApp
{
    public partial class baseForm : Form
    {
        // General use variables
        public int i;           // Often used for tallying for loops
        public int numShift;    // The number of shifts
        
        public bool[] machine = new bool[5];    // The machines in use

        // Alternative error messages for error1
        public string error1v1 = "Error: Please select A-Z.";
        public string error1v2 = "Error: Please assign a task.";
        public string error1v3 = "Error: Job array has been filled.";

        // Master variables
        public int MaxJobs = 10;
        public int MaxShift = 5;
        public int MaxMachine = 5;

        public baseForm()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.textileSpecsDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           this.tableTableAdapter.Fill(this.textileSpecsDataSet.Table);
        }

        // Read the input from the job selection.  Raise error for inappropriate inputs.
        // Establish a maximum number of jobs.
        private void addButton_Click(object sender, EventArgs e)
        {
            if (JobTable.Items.Count == 10)
            {
                error1.Text = error1v3;
                error1.Visible = true;
            }
            else
            {
                // Pull the string in and clear the field
                String jobVal = jobSel.Text;
                jobSel.Text = "";

                // For the purposed of this project, only singular alphabetical characters
                // should be input.  Ensure that the input is only one character in length
                if (jobVal.Length != 1)
                {
                    // Warns the user to provide proper inputs
                    error1.Text = error1v1;
                    error1.Visible = true;
                }
                else
                {
                    // Remove case sensivity by translating input to upper case
                    jobVal = jobVal.ToUpper();
                    // Convert the string into a char value
                    int inKey = jobVal[0];

                    // Ensure that the character is alphabetical
                    if (inKey >= 'A' && inKey <= 'Z')
                    {
                        // Add the new item to the job queue
                        JobTable.Items.Add(jobVal.ToUpper());
                        // Refresh the warning state
                        error1.Visible = false;
                    }
                    else
                    {
                        // Warns the user to provide a proper input
                        error1.Text = error1v1;
                        error1.Visible = true;
                    }
                }
            }
        }

        // Remove the items that are check within the input job array
        private void delButton_Click(object sender, EventArgs e)
        {
            // Create a bool array to track the state of each item
            bool[] delete = new bool[JobTable.Items.Count];
            error1.Visible = false;

            for (i = 0; i < JobTable.Items.Count; i++)
            {
                // Preset the item to false (unchecked).  Check the state and revise as
                // needed
                delete[i] = false;
                if (JobTable.GetItemCheckState(i) == CheckState.Checked) delete[i] = true;
            }

            // Run through delete array, and delete the flaged values from the array.
            // Working backwards ensures that the correct items are removed.
            for (i = JobTable.Items.Count - 1; i >= 0; i--)
            {
                if (delete[i])
                {
                    JobTable.Items.RemoveAt(i);
                }
            }
        }

        // Operate the program after receiving the input parameters
        private void runBut_Click(object sender, EventArgs e)
        {
            // Establish a gateway array for each of the input criteria
            bool[] pass = new bool[3];

            // Part 1: Ensure that there are jobs listed within the input array
            if (JobTable.Items.Count > 0) pass[0] = true;
            else pass[0] = false;

            // Part 2: Ensure that an appropriate number of shifts have been selected
            // For the sake of this project, the number ranges from 2-5
            String shiftVal = shiftSel.Text;

            // Follow the same process as inputing a job for selecting shifts (May benefit
            // from designating a function in future revisions)
            if (shiftVal.Length == 1)
            {
                int inShift = shiftVal[0];

                if (inShift >= '2' && inShift <= '1'+MaxShift-1)
                {
                    numShift = inShift - '2' + 2;
                    pass[1] = true;
                }
                else
                {
                    shiftSel.Text = "";
                    pass[1] = false;
                }
            }
            else pass[1] = false;

            // Part 3: Ensure that at least one machine has been selected for operation
            int numMachine = 0;
            pass[2] = false;

            // Run through each box within the machine list, and count the flags
            for (i=0;i<machineList.Items.Count;i++)
            {
                if (machineList.GetItemCheckState(i) == CheckState.Checked)
                {
                    machine[i] = true;
                    numMachine++;
                }
                else machine[i] = false;
            }

            if (numMachine > 0) pass[2] = true;

            // Step 4: Start the application process

            // Ensure that jobs are queued for completion
            if (pass[0]) error1.Visible = false;
            else
            {
                error1.Text = error1v2;
                error1.Visible = true;
            }

            // Ensure that shifts are selected
            if (pass[1]) error2.Visible = false;
            else error2.Visible = true;

            // Ensure that machines have been selected
            if (pass[2]) error3.Visible = false;
            else error3.Visible = true;

            // Only continue if all of the input parameters are acceptable
            if (pass[0] && pass[1] && pass[2])
            {
                //
                // STEP 0: Establish opening parameters
                //
                // The connection to the mock database
                String address = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + dataAddress.Text + ";Integrated Security = True; Connect Timeout = 30";
                SqlConnection data = new SqlConnection(@address);

                // Open access to the TextileSpecs database
                data.Open();

                // Disable the aspects of the UI that should not be altered during the process
                jobSel.Enabled = false;
                shiftSel.Enabled = false;
                addButton.Enabled = false;
                delButton.Enabled = false;
                JobTable.Enabled = false;
                machineList.Enabled = false;
                runButton.Enabled = false;      // Edit to allow for pausing in future revisions
                dataAddress.Enabled = false;

                // Receive input specification for Jobs, Shifts, and Machines
                int numJob = JobTable.Items.Count;      // Easier access to the number of jobs
                string[] jobTitle = new string[numJob]; // Temporary string array to access information from pool
                int[] jobValArray = new int[numJob];    // Converts the string array into int for access to database

                // Populate the jobTitle array with job titles in preparation for
                // determining the Job Value
                i = 0;
                foreach (Object job in JobTable.Items)
                {
                    jobTitle[i] = job.ToString();
                    i++;
                }

                // Populate the master array with Job Values corresponding to their ID
                for (i = 0; i < numJob; i++)
                {
                    jobValArray[i] = jobTitle[i][0] - 64;
                }

                // Prepare the shifts by determining the most jobs per shift
                int shiftSize = (int)Math.Ceiling((double)numJob / (double)numShift);
                // Designate the shift table to allocate jobs to each shift
                int[,] shiftTable = new int[shiftSize, numShift];

                // Null the shiftTable with -1
                for (i = 0; i < shiftSize; i++)
                {
                    for (int j = 0; j < numShift; j++)
                    {
                        shiftTable[i, j] = -1;
                    }
                }

                // Assign Job Keys to each shift
                int row;
                int col;
                for (i = 0; i < numJob; i++)
                {
                    row = (int)Math.Floor((double)i / (double)numShift);
                    col = (i + 1) % numShift;
                    shiftTable[row, col] = i;
                }

                // Establish the Machines.  Create an array that accounts for the machines,
                // their current job title, the printed specifications, and the display
                // specifications, within a 5x5 table, including the Job Key and Job Value
                Object[,] MachineTable = new Object[MaxMachine, 5];
                int jobsRemaining;

                for (int curShift = 0; curShift < numShift; curShift++)
                {
                    jobsRemaining = 0;
                    for (i = 0; i < shiftSize; i++)
                    {
                        if (shiftTable[i, curShift] != -1) jobsRemaining++;
                    }

                    MessageBox.Show("Shift " + (curShift + 1).ToString() + " start: " + jobsRemaining.ToString() + " job(s) remaining.");

                    while (jobsRemaining > 0)
                    {
                        // Prepare the default output text for the machine table
                        // For machines that aren't in use, their categories should be empty
                        for (i = 0; i < MaxMachine; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                MachineTable[i, j] = "-";
                            }
                        }

                        // Assign jobs to each active machine from the current shift
                        for (int mach = 0; mach < MaxMachine; mach++)
                        {
                            // If the selected machine is active, select the first non-nulled (! -1) job from 
                            // the current shift
                            if (machine[mach] == true)
                            {
                                // Run through the length of the current shift (shiftSize), searching
                                // for non-nulled jobs
                                for (i = 0; i < shiftSize; i++)
                                {
                                    // Allocate the Job Key and Job Value to the Machine Table
                                    if (shiftTable[i, curShift] != -1)
                                    {
                                        MachineTable[mach, 0] = shiftTable[i, curShift];
                                        MachineTable[mach, 1] = jobValArray[shiftTable[i, curShift]];
                                        shiftTable[i, curShift] = -1;
                                        break;
                                    }
                                }
                            }
                            // Else leave the Machine untouched
                            else
                            {
                                MachineTable[mach, 0] = "-";
                                MachineTable[mach, 1] = "-";
                            }
                        }

                        // Prepare to access the database
                        SqlCommand cmd = data.CreateCommand();
                        cmd.CommandType = CommandType.Text;

                        // Run through the machine table.  For machines that have been allocated
                        // jobs, retrieve the Job Title, Printer Specs, and Screen Specs
                        for (i = 0; i < MaxMachine; i++)
                        {
                            if (MachineTable[i, 1] != (Object)"-")
                            {
                                cmd.CommandText = "SELECT * FROM \"Table\" WHERE specID = " + MachineTable[i, 1].ToString() + ";";
                                cmd.ExecuteNonQuery();

                                DataTable DT = new DataTable();
                                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                                DA.Fill(DT);

                                foreach (DataRow ROW in DT.Rows)
                                {
                                    MachineTable[i, 2] = ROW["name"].ToString();
                                    MachineTable[i, 3] = ROW["print"].ToString();
                                    MachineTable[i, 4] = ROW["screen"].ToString();
                                }
                            }
                            // Else mark the machine as inactive at the given time
                            else
                            {
                                MachineTable[i, 2] = "-";
                                MachineTable[i, 3] = "-";
                                MachineTable[i, 4] = "-";
                            }
                        }

                        // I beleive that there has to be a better way to do this, but I
                        // haven't found or learned the method yet
                        //
                        // Display information that has been retrived into the machine table
                        job1.Text = MachineTable[0, 0].ToString() + ". " + MachineTable[0, 2].ToString();
                        job2.Text = MachineTable[1, 0].ToString() + ". " + MachineTable[1, 2].ToString();
                        job3.Text = MachineTable[2, 0].ToString() + ". " + MachineTable[2, 2].ToString();
                        job4.Text = MachineTable[3, 0].ToString() + ". " + MachineTable[3, 2].ToString();
                        job5.Text = MachineTable[4, 0].ToString() + ". " + MachineTable[4, 2].ToString();

                        print1.Text = MachineTable[0, 3].ToString();
                        print2.Text = MachineTable[1, 3].ToString();
                        print3.Text = MachineTable[2, 3].ToString();
                        print4.Text = MachineTable[3, 3].ToString();
                        print5.Text = MachineTable[4, 3].ToString();

                        screen1.Text = MachineTable[0, 4].ToString();
                        screen2.Text = MachineTable[1, 4].ToString();
                        screen3.Text = MachineTable[2, 4].ToString();
                        screen4.Text = MachineTable[3, 4].ToString();
                        screen5.Text = MachineTable[4, 4].ToString();

                        // Provide a short pause to signify the time taken to complete the jobs
                        // Find a method better than sleep in the future
                        Application.DoEvents();
                        Thread.Sleep(2000);

                        // Check for remaining jobs.  If none, the current shift will end,
                        // else the new jobs will be loaded onto the machines
                        jobsRemaining = 0;
                        for (i = 0; i < shiftSize; i++)
                        {
                            if (shiftTable[i, curShift] != -1) jobsRemaining++;
                        }
                        MessageBox.Show("Shift "+(curShift+1).ToString()+" jobs remaining: " + jobsRemaining.ToString());
                    }

                    // I had intended to develop a method to remove the jobs from the input
                    // array as they were completed, but I doubt that I'll have the time
                    MessageBox.Show("Shift " + (curShift + 1).ToString() + " has finished.");
                }

                MessageBox.Show("All jobs have been completed.");

                // Enable the aspects of the UI that should not be altered during the process
                jobSel.Enabled = true;
                shiftSel.Enabled = true;
                addButton.Enabled = true;
                delButton.Enabled = true;
                JobTable.Enabled = true;
                machineList.Enabled = true;
                runButton.Enabled = true;
                dataAddress.Enabled = true;

                data.Close();

                // Reset the form for the next simulation

                for (i = 0; i < numJob; i++)
                {
                    JobTable.Items.RemoveAt(0);
                }

                job1.Text = "-";
                job2.Text = "-";
                job3.Text = "-";
                job4.Text = "-";
                job5.Text = "-";

                print1.Text = "-";
                print2.Text = "-";
                print3.Text = "-";
                print4.Text = "-";
                print5.Text = "-";

                screen1.Text = "-";
                screen2.Text = "-";
                screen3.Text = "-";
                screen4.Text = "-";
                screen5.Text = "-";
            }
        }
    }
}
