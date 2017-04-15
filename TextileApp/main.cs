using System;
using System.Windows.Forms;

namespace TextileApp
{
    public partial class baseForm : Form
    {
        public int numJob = 0;
        public int numShift;
        public int numMachine;
        bool[] machine = new bool[5];
        public string jobVal;
        public string shiftVal;

        public string error1v1 = "Error: Please select A-Z.";
        public string error1v2 = "Error: Please assign a task.";

        public class LinkedList
        {
            private class Node
            {
                public Object key;
                public Object data;
                public Node next;
            }

            private Node head;

            public LinkedList()
            {
                head = null;
            }

            public void createNode(Object key,Object data)
            {
                Node newNode = new Node();

                newNode.key = key;
                newNode.data = data;
                newNode.next = null;

                addNode(newNode);
            }
            private void addNode(Node newNode)
            {
                Node curNode = new Node();

                if (head == null)
                {
                    head = newNode;
                    return;
                }

                curNode = head;
                bool allow = true;

                while (curNode.next != null)
                {
                    if (curNode.key == newNode.key)
                    {
                        curNode.data = newNode.data;
                        allow = false;
                        break;
                    }
                    curNode = curNode.next;
                }

                if (allow) curNode.next = newNode;

                return;
            }
            
            public void delNode(Object key)
            {
                // This linked list is designed to allow only unique values as keys
                Node prevNode = new Node();
                Node curNode = new Node();

                // Case 1: List is empty
                if (head == null) return;

                // Case 2: head is target for deletion
                if (head.key == key)
                {
                    // Relies on Automated Memory Management to care for unused objects
                    // Case 2a: head.next == null
                    if (head.next == null) head = null;
                    // Case 2b: head.next != null
                    else head = head.next;
                }

                // Case 3: Target for deletion comes after head
                prevNode = head;
                curNode = head.next;
                
                while (curNode != null)
                {
                    if (curNode.key == key)
                    {
                        prevNode.next = curNode.next;
                        break;
                    }
                    else
                    {
                        prevNode = curNode;
                        curNode = curNode.next;
                    }
                }

                return;
            }

            public Object getNode(Object key)
            {
                Node curNode = new Node();

                if (head == null) return null;
                else
                {
                    curNode = head;

                    while (curNode != null)
                    {
                        if (curNode.key == key) return curNode.data;
                        else curNode = curNode.next;
                    }
                }

                return null;
            }
        }

        LinkedList JobList = new LinkedList();

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
                jobVal = jobVal.ToUpper();
                int inKey = jobVal[0];

                if (inKey >= 'A' && inKey <= 'Z')
                {
                    inKey -= 64; // inKey -= 'A' + 1: Converts char to int starting at 1
                    outDisp.Text = inKey.ToString(); // Debugging in place of action
                    error1.Visible = false;
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
        }
    }
}
