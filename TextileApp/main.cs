using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextileApp
{
    public partial class baseForm : Form
    {
        public int numJob = 0;
        public int numShift;
        public int numMachine;
        
        public bool[] machine = new bool[5];
        public string jobVal;
        public string shiftVal;

        public string error1v1 = "Error: Please select A-Z.";
        public string error1v2 = "Error: Please assign a task.";

        List<int> newJobs = new List<int>();

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
                    inKey -= 64; // inKey -= 'A' + 1: Converts char to int starting at 1
                    screen1.Text = numJob.ToString();
                    screen2.Text = inKey.ToString();
                    //JobList.createNode(numJob, inKey);
                    numJob++;
                    error1.Visible = false;

                    newJobs.Add(inKey);
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
            pass[0] = true;
            // Step 2: Check Shifts
            shiftVal = shiftSel.Text;

            if (shiftVal.Length == 1)
            {
                int inShift = shiftVal[0];

                if (inShift >= '2' && inShift <= '5')
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

            for (int i=0;i<machineList.Items.Count;i++)
            {
                if (machineList.GetItemCheckState(i) == CheckState.Checked)
                {
                    machine[i] = true;
                    numMachine++;
                }
                else machine[i] = false;
            }

            if (numMachine > 0) pass[2] = true;

            // Step 4: Do Stuff

            if (pass[0]) error1.Visible = false;
            else
            {
                error1.Text = error1v2;
                error1.Visible = true;
            }

            if (pass[1]) error2.Visible = false;
            else error2.Visible = true;

            if (pass[2]) error3.Visible = false;
            else error3.Visible = true;

            if (pass[0] && pass[1] && pass[2])
            {

            }
        }

        private void JobTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            delButton.Enabled = false;

            for (int i=0;i<JobTable.Items.Count;i++)
            {
                if (JobTable.GetItemCheckState(i) == CheckState.Checked)
                {
                    delButton.Enabled = true;
                    break;
                }
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            bool[] delete = new bool[JobTable.Items.Count];

            for (int i = 0; i < JobTable.Items.Count; i++)
            {
                delete[i] = false;
                if (JobTable.GetItemCheckState(i) == CheckState.Checked)
                {
                    delete[i] = true;
                }
            }
            for (int i=JobTable.Items.Count-1;i>=0;i--)
            {
                if (delete[i])
                {
                    JobTable.Items.RemoveAt(i);
                }
            }
        }
    }
}
