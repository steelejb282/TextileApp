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
            this.label5 = new System.Windows.Forms.Label();
            this.outDisp = new System.Windows.Forms.Label();
            this.valSel = new System.Windows.Forms.TextBox();
            this.jobList = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.mess2 = new System.Windows.Forms.Label();
            this.mess3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.shiftSel = new System.Windows.Forms.TextBox();
            this.error2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.runBut = new System.Windows.Forms.Button();
            this.mess4 = new System.Windows.Forms.Label();
            this.machineList = new System.Windows.Forms.CheckedListBox();
            this.mess5 = new System.Windows.Forms.Label();
            this.mess6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mess1
            // 
            this.mess1.AutoSize = true;
            this.mess1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mess1.Location = new System.Drawing.Point(25, 25);
            this.mess1.Name = "mess1";
            this.mess1.Size = new System.Drawing.Size(501, 37);
            this.mess1.TabIndex = 0;
            this.mess1.Tag = "mess1";
            this.mess1.Text = "Select a product to produce (A-Z):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(25, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(364, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "Error: Please select A-Z.";
            this.label5.Visible = false;
            // 
            // outDisp
            // 
            this.outDisp.AutoSize = true;
            this.outDisp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.outDisp.Location = new System.Drawing.Point(425, 90);
            this.outDisp.Name = "outDisp";
            this.outDisp.Size = new System.Drawing.Size(27, 37);
            this.outDisp.TabIndex = 2;
            this.outDisp.Tag = "outDisp";
            this.outDisp.Text = "-";
            // 
            // valSel
            // 
            this.valSel.Location = new System.Drawing.Point(35, 80);
            this.valSel.Name = "valSel";
            this.valSel.Size = new System.Drawing.Size(246, 44);
            this.valSel.TabIndex = 3;
            this.valSel.Tag = "input";
            this.valSel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // jobList
            // 
            this.jobList.FormattingEnabled = true;
            this.jobList.ItemHeight = 37;
            this.jobList.Location = new System.Drawing.Point(35, 200);
            this.jobList.Name = "jobList";
            this.jobList.Size = new System.Drawing.Size(500, 374);
            this.jobList.TabIndex = 4;
            this.jobList.Tag = "jobList";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(35, 600);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(245, 75);
            this.addButton.TabIndex = 5;
            this.addButton.Tag = "addBut";
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // delButton
            // 
            this.delButton.Enabled = false;
            this.delButton.Location = new System.Drawing.Point(300, 600);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(245, 75);
            this.delButton.TabIndex = 6;
            this.delButton.Tag = "delBut";
            this.delButton.Text = "Delete";
            this.delButton.UseVisualStyleBackColor = true;
            // 
            // mess2
            // 
            this.mess2.AutoSize = true;
            this.mess2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mess2.Location = new System.Drawing.Point(295, 90);
            this.mess2.Name = "mess2";
            this.mess2.Size = new System.Drawing.Size(123, 37);
            this.mess2.TabIndex = 7;
            this.mess2.Text = "Output:";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 685);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.error2);
            this.panel2.Controls.Add(this.shiftSel);
            this.panel2.Controls.Add(this.mess3);
            this.panel2.Location = new System.Drawing.Point(575, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 185);
            this.panel2.TabIndex = 10;
            // 
            // shiftSel
            // 
            this.shiftSel.Location = new System.Drawing.Point(237, 63);
            this.shiftSel.Name = "shiftSel";
            this.shiftSel.Size = new System.Drawing.Size(235, 44);
            this.shiftSel.TabIndex = 0;
            this.shiftSel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.mess6);
            this.panel3.Controls.Add(this.mess5);
            this.panel3.Controls.Add(this.machineList);
            this.panel3.Controls.Add(this.mess4);
            this.panel3.Location = new System.Drawing.Point(575, 215);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(545, 480);
            this.panel3.TabIndex = 11;
            // 
            // runBut
            // 
            this.runBut.Location = new System.Drawing.Point(595, 600);
            this.runBut.Name = "runBut";
            this.runBut.Size = new System.Drawing.Size(515, 75);
            this.runBut.TabIndex = 12;
            this.runBut.Text = "Run";
            this.runBut.UseVisualStyleBackColor = true;
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
            // machineList
            // 
            this.machineList.BackColor = System.Drawing.SystemColors.ControlDark;
            this.machineList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.machineList.FormattingEnabled = true;
            this.machineList.Items.AddRange(new object[] {
            "Machine 1",
            "Machine 2",
            "Machine 3",
            "Machine 4",
            "Machine 5"});
            this.machineList.Location = new System.Drawing.Point(3, 96);
            this.machineList.Name = "machineList";
            this.machineList.Size = new System.Drawing.Size(525, 236);
            this.machineList.TabIndex = 1;
            // 
            // mess5
            // 
            this.mess5.AutoSize = true;
            this.mess5.Location = new System.Drawing.Point(250, 50);
            this.mess5.Name = "mess5";
            this.mess5.Size = new System.Drawing.Size(111, 37);
            this.mess5.TabIndex = 2;
            this.mess5.Text = "Printer";
            // 
            // mess6
            // 
            this.mess6.AutoSize = true;
            this.mess6.Location = new System.Drawing.Point(375, 50);
            this.mess6.Name = "mess6";
            this.mess6.Size = new System.Drawing.Size(117, 37);
            this.mess6.TabIndex = 3;
            this.mess6.Text = "Screen";
            // 
            // baseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1171, 713);
            this.Controls.Add(this.runBut);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.mess2);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.jobList);
            this.Controls.Add(this.valSel);
            this.Controls.Add(this.outDisp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mess1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "baseForm";
            this.Text = "Textile Management";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextileSpecsDataSet textileSpecsDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private TextileSpecsDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private TextileSpecsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.Button delBut;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox itemSel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label outputVal;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label inputDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label error1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mess1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label outDisp;
        private System.Windows.Forms.TextBox valSel;
        private System.Windows.Forms.ListBox jobList;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Label mess2;
        private System.Windows.Forms.Label mess3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label error2;
        private System.Windows.Forms.TextBox shiftSel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button runBut;
        private System.Windows.Forms.Label mess6;
        private System.Windows.Forms.Label mess5;
        private System.Windows.Forms.CheckedListBox machineList;
        private System.Windows.Forms.Label mess4;
    }
}

