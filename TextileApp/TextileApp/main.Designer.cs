namespace TextileApp
{
    partial class baseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mess1 = new System.Windows.Forms.Label();
            this.mess3 = new System.Windows.Forms.Label();
            this.mess4 = new System.Windows.Forms.Label();
            this.mess6 = new System.Windows.Forms.Label();
            this.mess7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.runButton = new System.Windows.Forms.Button();
            this.error1 = new System.Windows.Forms.Label();
            this.jobSel = new System.Windows.Forms.TextBox();
            this.JobTable = new System.Windows.Forms.CheckedListBox();
            this.delButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.error2 = new System.Windows.Forms.Label();
            this.shiftSel = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.error3 = new System.Windows.Forms.Label();
            this.screen5 = new System.Windows.Forms.Label();
            this.print5 = new System.Windows.Forms.Label();
            this.screen4 = new System.Windows.Forms.Label();
            this.print4 = new System.Windows.Forms.Label();
            this.screen3 = new System.Windows.Forms.Label();
            this.print3 = new System.Windows.Forms.Label();
            this.screen2 = new System.Windows.Forms.Label();
            this.print2 = new System.Windows.Forms.Label();
            this.screen1 = new System.Windows.Forms.Label();
            this.print1 = new System.Windows.Forms.Label();
            this.machineList = new System.Windows.Forms.CheckedListBox();
            this.job5 = new System.Windows.Forms.Label();
            this.job4 = new System.Windows.Forms.Label();
            this.job3 = new System.Windows.Forms.Label();
            this.job2 = new System.Windows.Forms.Label();
            this.job1 = new System.Windows.Forms.Label();
            this.mess5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mess1
            // 
            this.mess1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mess1.Location = new System.Drawing.Point(11, 8);
            this.mess1.Name = "mess1";
            this.mess1.Size = new System.Drawing.Size(507, 84);
            this.mess1.TabIndex = 0;
            this.mess1.Tag = "mess1";
            this.mess1.Text = "Select a product to produce (A-Z):";
            // 
            // mess3
            // 
            this.mess3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mess3.Location = new System.Drawing.Point(10, 8);
            this.mess3.Name = "mess3";
            this.mess3.Size = new System.Drawing.Size(528, 84);
            this.mess3.TabIndex = 8;
            this.mess3.Tag = "mess3";
            this.mess3.Text = "State the number of operating shifts (2-5):";
            // 
            // mess4
            // 
            this.mess4.AutoSize = true;
            this.mess4.Location = new System.Drawing.Point(10, 10);
            this.mess4.Name = "mess4";
            this.mess4.Size = new System.Drawing.Size(470, 37);
            this.mess4.TabIndex = 0;
            this.mess4.Text = "Select the machines to be used:";
            // 
            // mess6
            // 
            this.mess6.AutoSize = true;
            this.mess6.Location = new System.Drawing.Point(250, 50);
            this.mess6.Name = "mess6";
            this.mess6.Size = new System.Drawing.Size(111, 37);
            this.mess6.TabIndex = 2;
            this.mess6.Text = "Printer";
            this.mess6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mess7
            // 
            this.mess7.AutoSize = true;
            this.mess7.Location = new System.Drawing.Point(375, 50);
            this.mess7.Name = "mess7";
            this.mess7.Size = new System.Drawing.Size(117, 37);
            this.mess7.TabIndex = 3;
            this.mess7.Text = "Screen";
            this.mess7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.runButton);
            this.panel1.Controls.Add(this.error1);
            this.panel1.Controls.Add(this.jobSel);
            this.panel1.Controls.Add(this.JobTable);
            this.panel1.Controls.Add(this.delButton);
            this.panel1.Controls.Add(this.mess1);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 580);
            this.panel1.TabIndex = 9;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(272, 480);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(169, 75);
            this.runButton.TabIndex = 12;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runBut_Click);
            // 
            // error1
            // 
            this.error1.AutoSize = true;
            this.error1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.error1.ForeColor = System.Drawing.Color.Red;
            this.error1.Location = new System.Drawing.Point(8, 146);
            this.error1.Name = "error1";
            this.error1.Size = new System.Drawing.Size(364, 37);
            this.error1.TabIndex = 1;
            this.error1.Text = "Error: Please select A-Z.";
            this.error1.Visible = false;
            // 
            // jobSel
            // 
            this.jobSel.AcceptsReturn = true;
            this.jobSel.Location = new System.Drawing.Point(184, 63);
            this.jobSel.Name = "jobSel";
            this.jobSel.Size = new System.Drawing.Size(246, 44);
            this.jobSel.TabIndex = 3;
            this.jobSel.Tag = "input";
            this.jobSel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // JobTable
            // 
            this.JobTable.CheckOnClick = true;
            this.JobTable.FormattingEnabled = true;
            this.JobTable.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J"});
            this.JobTable.Location = new System.Drawing.Point(15, 200);
            this.JobTable.Name = "JobTable";
            this.JobTable.Size = new System.Drawing.Size(240, 355);
            this.JobTable.TabIndex = 1;
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(272, 281);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(169, 75);
            this.delButton.TabIndex = 6;
            this.delButton.Tag = "delBut";
            this.delButton.Text = "Delete";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(272, 200);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(169, 75);
            this.addButton.TabIndex = 5;
            this.addButton.Tag = "addBut";
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.error2);
            this.panel2.Controls.Add(this.shiftSel);
            this.panel2.Controls.Add(this.mess3);
            this.panel2.Location = new System.Drawing.Point(490, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 185);
            this.panel2.TabIndex = 10;
            // 
            // error2
            // 
            this.error2.AutoSize = true;
            this.error2.ForeColor = System.Drawing.Color.Red;
            this.error2.Location = new System.Drawing.Point(10, 135);
            this.error2.Name = "error2";
            this.error2.Size = new System.Drawing.Size(358, 37);
            this.error2.TabIndex = 9;
            this.error2.Tag = "error2";
            this.error2.Text = "Error: Please select 2-5.";
            this.error2.Visible = false;
            // 
            // shiftSel
            // 
            this.shiftSel.AllowDrop = true;
            this.shiftSel.Location = new System.Drawing.Point(237, 63);
            this.shiftSel.Name = "shiftSel";
            this.shiftSel.Size = new System.Drawing.Size(235, 44);
            this.shiftSel.TabIndex = 0;
            this.shiftSel.Text = "3";
            this.shiftSel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.job5);
            this.panel3.Controls.Add(this.job4);
            this.panel3.Controls.Add(this.job3);
            this.panel3.Controls.Add(this.job2);
            this.panel3.Controls.Add(this.job1);
            this.panel3.Controls.Add(this.mess5);
            this.panel3.Controls.Add(this.error3);
            this.panel3.Controls.Add(this.screen5);
            this.panel3.Controls.Add(this.print5);
            this.panel3.Controls.Add(this.screen4);
            this.panel3.Controls.Add(this.print4);
            this.panel3.Controls.Add(this.screen3);
            this.panel3.Controls.Add(this.print3);
            this.panel3.Controls.Add(this.screen2);
            this.panel3.Controls.Add(this.print2);
            this.panel3.Controls.Add(this.screen1);
            this.panel3.Controls.Add(this.print1);
            this.panel3.Controls.Add(this.mess7);
            this.panel3.Controls.Add(this.mess6);
            this.panel3.Controls.Add(this.machineList);
            this.panel3.Controls.Add(this.mess4);
            this.panel3.Location = new System.Drawing.Point(490, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(545, 378);
            this.panel3.TabIndex = 11;
            // 
            // error3
            // 
            this.error3.AutoSize = true;
            this.error3.ForeColor = System.Drawing.Color.Red;
            this.error3.Location = new System.Drawing.Point(10, 325);
            this.error3.Name = "error3";
            this.error3.Size = new System.Drawing.Size(460, 37);
            this.error3.TabIndex = 14;
            this.error3.Text = "Error: Please select a machine.";
            this.error3.Visible = false;
            // 
            // screen5
            // 
            this.screen5.Location = new System.Drawing.Point(383, 270);
            this.screen5.Name = "screen5";
            this.screen5.Size = new System.Drawing.Size(100, 37);
            this.screen5.TabIndex = 13;
            this.screen5.Text = "-";
            this.screen5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // print5
            // 
            this.print5.Location = new System.Drawing.Point(255, 270);
            this.print5.Name = "print5";
            this.print5.Size = new System.Drawing.Size(100, 37);
            this.print5.TabIndex = 12;
            this.print5.Text = "-";
            this.print5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // screen4
            // 
            this.screen4.Location = new System.Drawing.Point(383, 229);
            this.screen4.Name = "screen4";
            this.screen4.Size = new System.Drawing.Size(100, 37);
            this.screen4.TabIndex = 11;
            this.screen4.Text = "-";
            this.screen4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // print4
            // 
            this.print4.Location = new System.Drawing.Point(255, 229);
            this.print4.Name = "print4";
            this.print4.Size = new System.Drawing.Size(100, 37);
            this.print4.TabIndex = 10;
            this.print4.Text = "-";
            this.print4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // screen3
            // 
            this.screen3.Location = new System.Drawing.Point(383, 186);
            this.screen3.Name = "screen3";
            this.screen3.Size = new System.Drawing.Size(100, 37);
            this.screen3.TabIndex = 9;
            this.screen3.Text = "-";
            this.screen3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // print3
            // 
            this.print3.Location = new System.Drawing.Point(255, 186);
            this.print3.Name = "print3";
            this.print3.Size = new System.Drawing.Size(100, 37);
            this.print3.TabIndex = 8;
            this.print3.Text = "-";
            this.print3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // screen2
            // 
            this.screen2.Location = new System.Drawing.Point(383, 143);
            this.screen2.Name = "screen2";
            this.screen2.Size = new System.Drawing.Size(100, 37);
            this.screen2.TabIndex = 7;
            this.screen2.Text = "-";
            this.screen2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // print2
            // 
            this.print2.Location = new System.Drawing.Point(255, 143);
            this.print2.Name = "print2";
            this.print2.Size = new System.Drawing.Size(100, 37);
            this.print2.TabIndex = 6;
            this.print2.Text = "-";
            this.print2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // screen1
            // 
            this.screen1.Location = new System.Drawing.Point(383, 100);
            this.screen1.Name = "screen1";
            this.screen1.Size = new System.Drawing.Size(100, 37);
            this.screen1.TabIndex = 5;
            this.screen1.Text = "-";
            this.screen1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // print1
            // 
            this.print1.Location = new System.Drawing.Point(255, 100);
            this.print1.Name = "print1";
            this.print1.Size = new System.Drawing.Size(100, 37);
            this.print1.TabIndex = 4;
            this.print1.Text = "-";
            this.print1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // machineList
            // 
            this.machineList.BackColor = System.Drawing.SystemColors.ControlDark;
            this.machineList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.machineList.CheckOnClick = true;
            this.machineList.FormattingEnabled = true;
            this.machineList.Items.AddRange(new object[] {
            "M1",
            "M2",
            "M3",
            "M4",
            "M5"});
            this.machineList.Location = new System.Drawing.Point(7, 96);
            this.machineList.Name = "machineList";
            this.machineList.Size = new System.Drawing.Size(117, 234);
            this.machineList.TabIndex = 1;
            // 
            // job5
            // 
            this.job5.Location = new System.Drawing.Point(125, 270);
            this.job5.Name = "job5";
            this.job5.Size = new System.Drawing.Size(100, 37);
            this.job5.TabIndex = 20;
            this.job5.Text = "-";
            this.job5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // job4
            // 
            this.job4.Location = new System.Drawing.Point(125, 229);
            this.job4.Name = "job4";
            this.job4.Size = new System.Drawing.Size(100, 37);
            this.job4.TabIndex = 19;
            this.job4.Text = "-";
            this.job4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // job3
            // 
            this.job3.Location = new System.Drawing.Point(125, 186);
            this.job3.Name = "job3";
            this.job3.Size = new System.Drawing.Size(100, 37);
            this.job3.TabIndex = 18;
            this.job3.Text = "-";
            this.job3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // job2
            // 
            this.job2.Location = new System.Drawing.Point(125, 143);
            this.job2.Name = "job2";
            this.job2.Size = new System.Drawing.Size(100, 37);
            this.job2.TabIndex = 17;
            this.job2.Text = "-";
            this.job2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // job1
            // 
            this.job1.Location = new System.Drawing.Point(125, 100);
            this.job1.Name = "job1";
            this.job1.Size = new System.Drawing.Size(100, 37);
            this.job1.TabIndex = 16;
            this.job1.Text = "-";
            this.job1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mess5
            // 
            this.mess5.Location = new System.Drawing.Point(125, 50);
            this.mess5.Name = "mess5";
            this.mess5.Size = new System.Drawing.Size(100, 37);
            this.mess5.TabIndex = 15;
            this.mess5.Text = "Job";
            this.mess5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // baseForm
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 610);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "baseForm";
            this.Text = "Textile Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextileSpecsDataSet textileSpecsDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private TextileSpecsDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private TextileSpecsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label mess1;
        private System.Windows.Forms.Label error1;
        private System.Windows.Forms.TextBox jobSel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Label mess3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label error2;
        private System.Windows.Forms.TextBox shiftSel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label mess7;
        private System.Windows.Forms.Label mess6;
        private System.Windows.Forms.CheckedListBox machineList;
        private System.Windows.Forms.Label mess4;
        private System.Windows.Forms.Label screen5;
        private System.Windows.Forms.Label print5;
        private System.Windows.Forms.Label screen4;
        private System.Windows.Forms.Label print4;
        private System.Windows.Forms.Label screen3;
        private System.Windows.Forms.Label print3;
        private System.Windows.Forms.Label screen2;
        private System.Windows.Forms.Label print2;
        private System.Windows.Forms.Label screen1;
        private System.Windows.Forms.Label print1;
        private System.Windows.Forms.Label error3;
        private System.Windows.Forms.CheckedListBox JobTable;
        private System.Windows.Forms.Label job5;
        private System.Windows.Forms.Label job4;
        private System.Windows.Forms.Label job3;
        private System.Windows.Forms.Label job2;
        private System.Windows.Forms.Label job1;
        private System.Windows.Forms.Label mess5;
    }
}

