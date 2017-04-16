using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace TextileApp
{
    public partial class baseForm : Form
    {
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

                MessageBox.Show(shiftSize.ToString());

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
