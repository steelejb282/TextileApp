using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace TextileApp
{
    public partial class baseForm : Form
    {
        SqlConnection data = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\John\Source\Github\TextileApp\TextileApp\TextileSpecs.mdf;Integrated Security=True;Connect Timeout=30");
        public int i;
        public int numShift;
        public int numMachine;
        
        public bool[] machine = new bool[5];
        public string jobVal;
        public string shiftVal;

        public string error1v1 = "Error: Please select A-Z.";
        public string error1v2 = "Error: Please assign a task.";

        public bool inProgress = false;

        public int MaxShift = 5;

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
            // TODO: This line of code loads data into the 'textileSpecsDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.textileSpecsDataSet.Table);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            jobVal = jobSel.Text;
            jobSel.Text = "";

            if (jobVal.Length != 1)
            {
                error1.Text = error1v1;
                error1.Visible = true;
            }
            else
            {
                jobVal = jobVal.ToUpper();
                int inKey = jobVal[0];

                if (inKey >= 'A' && inKey <= 'Z')
                {
                    // Add the new item to the job queue
                    JobTable.Items.Add(jobVal.ToUpper());
                    error1.Visible = false;
                }
                else
                {
                    error1.Text = error1v1;
                    error1.Visible = true;
                }
            }
        }

        private void runBut_Click(object sender, EventArgs e)
        {
            bool[] pass = new bool[3];

            // Step 1: Check Job List
            if (JobTable.Items.Count > 0) pass[0] = true;
            else pass[0] = false;

            // Step 2: Check Shifts
            shiftVal = shiftSel.Text;

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

            // Step 3: Check Machines
            numMachine = 0;
            pass[2] = false;

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
                // Open access to the TextileSpecs database
                data.Open();

                // Disable the aspects of the UI that should not be altered during the process
                jobSel.Enabled = false;
                shiftSel.Enabled = false;
                addButton.Enabled = false;
                delButton.Enabled = false;
                JobTable.Enabled = false;
                machineList.Enabled = false;
                // Alter the Run Button to allow for Pausing
                runButton.Text = "Pause";
                inProgress = true;

                // Receive input specification for Jobs, Shifts, and Machines
                int numJob = JobTable.Items.Count;
                int[,] fullJobArr = new int[numJob, 2];
                string[] jobTitle = new string[numJob];

                // Establish master job pool that tracks Job ID and Job Value

                // Fill the array with Job IDs
                for (i = 0; i < numJob; i++) fullJobArr[i, 0] = i;

                // Populate the jobTitle array with job titles in preparation for determining the Job Value
                i = 0;
                foreach (Object job in JobTable.Items)
                {
                    jobTitle[i] = job.ToString();
                    i++;
                }

                // Populate the master array with Job Values corresponding to their ID
                for (i = 0; i < numJob; i++)
                {
                    fullJobArr[i, 1] = jobTitle[i][0] - 64;
                }

                // Prepare the shifts
                int shiftSize = (int)Math.Ceiling((double)numJob / (double)numShift);
                int[,] shiftTable = new int[2 * numShift, shiftSize];

                // Assign jobs to shifts - Even columns refer to the Job Key, Odd columns refer to the Job Value
                for (i = 0; i < shiftSize; i++)
                {
                    for (int j = 0; j < numShift; j++)
                    {
                        if (i * numShift + j >= numJob)
                        {
                            shiftTable[j * 2, i] = -1;
                            shiftTable[j * 2 + 1, i] = -1;
                        }
                        else
                        {
                            shiftTable[j * 2, i] = fullJobArr[i * numShift + j, 0];
                            shiftTable[j * 2 + 1, i] = fullJobArr[i * numShift + j, 1];
                        }
                    }
                }

                // Establish the Machines.  Create an array that accounts for the machines,
                // their current job title, the printed specifications, and the display
                // specifications, within a 5x6 table, including the Job Key and Job Value
                Object[,] MachineTable = new Object[5, 5];
                int jobsRemaining = 1;

                for (int curShift = 0; curShift < numShift; curShift++)
                {
                    while (jobsRemaining > 0)
                    {
                        for (i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                MachineTable[i, j] = "-";
                            }
                        }

                        for (int mach = 0; mach < 5; mach++)
                        {
                            if (machine[mach] == true)
                            {
                                for (i = 0; i < shiftSize; i++)
                                {
                                    MessageBox.Show(shiftTable[curShift * 2, i].ToString() + ". " + shiftTable[curShift * 2 + 1, i].ToString());
                                    if (shiftTable[curShift*2, i] != -1)
                                    {
                                        MachineTable[mach, 0] = shiftTable[curShift*2, i];
                                        MachineTable[mach, 1] = shiftTable[curShift*2+1, i];
                                        shiftTable[curShift*2, i] = -1;
                                        shiftTable[curShift*2+1, i] = -1;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                MachineTable[mach, 0] = "-";
                                MachineTable[mach, 1] = "-";
                            }
                        }

                        SqlCommand cmd = data.CreateCommand();
                        cmd.CommandType = CommandType.Text;

                        for (i = 0; i < 5; i++)
                        {
                            if (MachineTable[i, 1] != (Object)"-")
                            {
                                cmd.CommandText = "SELECT * FROM \"Table\" WHERE specID = " + MachineTable[i, 1].ToString() + ";";
                                cmd.ExecuteNonQuery();

                                DataTable DT = new DataTable();
                                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                                DA.Fill(DT);

                                foreach (DataRow row in DT.Rows)
                                {
                                    MachineTable[i, 2] = row["name"].ToString();
                                    MachineTable[i, 3] = row["print"].ToString();
                                    MachineTable[i, 4] = row["screen"].ToString();
                                }
                            }
                            else
                            {
                                MachineTable[i, 2] = "-";
                                MachineTable[i, 3] = "-";
                                MachineTable[i, 4] = "-";
                            }
                        }

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

                        Application.DoEvents();
                        Thread.Sleep(2000);

                        jobsRemaining = 0;
                        for (i = 0; i < shiftSize; i++)
                        {
                            if (shiftTable[curShift*2, i] != -1) jobsRemaining++;
                        }
                    }
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
                // Alter the Run Button to allow for Pausing
                runButton.Text = "Run";
                inProgress = false;

                data.Close();
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            bool[] delete = new bool[JobTable.Items.Count];
            error1.Visible = false;

            for (i = 0; i < JobTable.Items.Count; i++)
            {
                delete[i] = false;
                if (JobTable.GetItemCheckState(i) == CheckState.Checked)
                {
                    delete[i] = true;
                }
            }
            for (i=JobTable.Items.Count-1;i>=0;i--)
            {
                if (delete[i])
                {
                    JobTable.Items.RemoveAt(i);
                }
            }
        }
    }
}
