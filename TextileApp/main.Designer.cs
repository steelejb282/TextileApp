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
            this.input = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.mess2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mess1
            // 
            this.mess1.AutoSize = true;
            this.mess1.Location = new System.Drawing.Point(15, 15);
            this.mess1.Name = "mess1";
            this.mess1.Size = new System.Drawing.Size(501, 37);
            this.mess1.TabIndex = 0;
            this.mess1.Tag = "mess1";
            this.mess1.Text = "Select a product to produce (A-Z):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(15, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(364, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "Error: Please select A-Z.";
            this.label5.Visible = false;
            // 
            // outDisp
            // 
            this.outDisp.AutoSize = true;
            this.outDisp.Location = new System.Drawing.Point(414, 80);
            this.outDisp.Name = "outDisp";
            this.outDisp.Size = new System.Drawing.Size(27, 37);
            this.outDisp.TabIndex = 2;
            this.outDisp.Tag = "outDisp";
            this.outDisp.Text = "-";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(25, 70);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(246, 44);
            this.input.TabIndex = 3;
            this.input.Tag = "input";
            this.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 37;
            this.listBox2.Location = new System.Drawing.Point(25, 190);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(500, 374);
            this.listBox2.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(25, 590);
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
            this.delButton.Location = new System.Drawing.Point(290, 590);
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
            this.mess2.Location = new System.Drawing.Point(294, 80);
            this.mess2.Name = "mess2";
            this.mess2.Size = new System.Drawing.Size(123, 37);
            this.mess2.TabIndex = 7;
            this.mess2.Text = "Output:";
            // 
            // baseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 687);
            this.Controls.Add(this.mess2);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.input);
            this.Controls.Add(this.outDisp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mess1);
            this.Name = "baseForm";
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
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Label mess2;
    }
}

