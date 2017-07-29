namespace SchoolApp
{
    partial class ucFee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_addexpense = new MetroFramework.Controls.MetroButton();
            this.txt_expensestype = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_addexpensepayment = new MetroFramework.Controls.MetroButton();
            this.txt_expenseamount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.com_expensetype = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.com_classname = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addexpense
            // 
            this.btn_addexpense.Location = new System.Drawing.Point(226, 236);
            this.btn_addexpense.Name = "btn_addexpense";
            this.btn_addexpense.Size = new System.Drawing.Size(75, 23);
            this.btn_addexpense.TabIndex = 10;
            this.btn_addexpense.Text = "Add";
            this.btn_addexpense.UseSelectable = true;
            this.btn_addexpense.Click += new System.EventHandler(this.btn_addexpense_Click);
            // 
            // txt_expensestype
            // 
            // 
            // 
            // 
            this.txt_expensestype.CustomButton.Image = null;
            this.txt_expensestype.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txt_expensestype.CustomButton.Name = "";
            this.txt_expensestype.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_expensestype.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_expensestype.CustomButton.TabIndex = 1;
            this.txt_expensestype.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_expensestype.CustomButton.UseSelectable = true;
            this.txt_expensestype.CustomButton.Visible = false;
            this.txt_expensestype.Lines = new string[0];
            this.txt_expensestype.Location = new System.Drawing.Point(236, 176);
            this.txt_expensestype.MaxLength = 32767;
            this.txt_expensestype.Name = "txt_expensestype";
            this.txt_expensestype.PasswordChar = '\0';
            this.txt_expensestype.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_expensestype.SelectedText = "";
            this.txt_expensestype.SelectionLength = 0;
            this.txt_expensestype.SelectionStart = 0;
            this.txt_expensestype.ShortcutsEnabled = true;
            this.txt_expensestype.Size = new System.Drawing.Size(155, 23);
            this.txt_expensestype.TabIndex = 9;
            this.txt_expensestype.UseSelectable = true;
            this.txt_expensestype.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_expensestype.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(118, 177);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(103, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Expense Type:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(48, 65);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Expense:";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // btn_addexpensepayment
            // 
            this.btn_addexpensepayment.Location = new System.Drawing.Point(727, 239);
            this.btn_addexpensepayment.Name = "btn_addexpensepayment";
            this.btn_addexpensepayment.Size = new System.Drawing.Size(75, 23);
            this.btn_addexpensepayment.TabIndex = 14;
            this.btn_addexpensepayment.Text = "Add";
            this.btn_addexpensepayment.UseSelectable = true;
            this.btn_addexpensepayment.Click += new System.EventHandler(this.btn_addexpensepayment_Click);
            // 
            // txt_expenseamount
            // 
            // 
            // 
            // 
            this.txt_expenseamount.CustomButton.Image = null;
            this.txt_expenseamount.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txt_expenseamount.CustomButton.Name = "";
            this.txt_expenseamount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_expenseamount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_expenseamount.CustomButton.TabIndex = 1;
            this.txt_expenseamount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_expenseamount.CustomButton.UseSelectable = true;
            this.txt_expenseamount.CustomButton.Visible = false;
            this.txt_expenseamount.Lines = new string[0];
            this.txt_expenseamount.Location = new System.Drawing.Point(737, 179);
            this.txt_expenseamount.MaxLength = 32767;
            this.txt_expenseamount.Name = "txt_expenseamount";
            this.txt_expenseamount.PasswordChar = '\0';
            this.txt_expenseamount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_expenseamount.SelectedText = "";
            this.txt_expenseamount.SelectionLength = 0;
            this.txt_expenseamount.SelectionStart = 0;
            this.txt_expenseamount.ShortcutsEnabled = true;
            this.txt_expenseamount.Size = new System.Drawing.Size(155, 23);
            this.txt_expenseamount.TabIndex = 13;
            this.txt_expenseamount.UseSelectable = true;
            this.txt_expenseamount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_expenseamount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(612, 180);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(124, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Expense Amount:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(550, 65);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(130, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Expense Payment:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(632, 138);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(103, 19);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "Expense Type:";
            // 
            // com_expensetype
            // 
            this.com_expensetype.FormattingEnabled = true;
            this.com_expensetype.ItemHeight = 23;
            this.com_expensetype.Location = new System.Drawing.Point(737, 138);
            this.com_expensetype.Name = "com_expensetype";
            this.com_expensetype.Size = new System.Drawing.Size(155, 29);
            this.com_expensetype.TabIndex = 16;
            this.com_expensetype.UseSelectable = true;
            this.com_expensetype.Click += new System.EventHandler(this.com_expensetype_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(397, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(898, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "*";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(898, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(376, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "*";
            // 
            // com_classname
            // 
            this.com_classname.FormattingEnabled = true;
            this.com_classname.ItemHeight = 23;
            this.com_classname.Location = new System.Drawing.Point(236, 136);
            this.com_classname.Name = "com_classname";
            this.com_classname.Size = new System.Drawing.Size(134, 29);
            this.com_classname.TabIndex = 22;
            this.com_classname.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(118, 137);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(118, 19);
            this.metroLabel6.TabIndex = 21;
            this.metroLabel6.Text = "Standard Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(317, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(419, 150);
            this.dataGridView1.TabIndex = 24;
            // 
            // ucFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.com_classname);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.com_expensetype);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btn_addexpensepayment);
            this.Controls.Add(this.txt_expenseamount);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btn_addexpense);
            this.Controls.Add(this.txt_expensestype);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ucFee";
            this.Size = new System.Drawing.Size(983, 519);
            this.Load += new System.EventHandler(this.ucFee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_addexpense;
        private MetroFramework.Controls.MetroTextBox txt_expensestype;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btn_addexpensepayment;
        private MetroFramework.Controls.MetroTextBox txt_expenseamount;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox com_expensetype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox com_classname;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
