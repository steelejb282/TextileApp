using System;
using System.Windows.Forms;

namespace TextileApp
{
    public partial class baseForm : Form
    {
        public string jobVal;
        public string shiftVal;

        public string error1v1 = "Error: Please select A-Z.";
        public string error1v2 = "Error: Please assign a task.";

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

            if (jobVal.Length != 1)
            {
                jobSel.Text = "";
                outDisp.Text = "-";
                error1.Text = error1v1;
                error1.Visible = true;
            }
            else
            {
                error1.Visible = false;
                jobVal = jobVal.ToUpper();
                int inKey = jobVal[0];

                if (inKey >= 'A' && inKey <= 'Z')
                {
                    inKey -= 64;
                    outDisp.Text = inKey.ToString();
                }
                else
                {
                    jobSel.Text = "";
                    outDisp.Text = "-";
                    error1.Text = error1v1;
                    error1.Visible = true;
                }
            }
        }

        private void runBut_Click(object sender, EventArgs e)
        {

            // Step 1: Check Job List
            // Step 2: Check Shifts
            // Step 3: Check Machines
            // Step 4: Do Stuff
        }
    }
}
