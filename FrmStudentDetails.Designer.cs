namespace SchoolApp
{
    partial class FrmStudentDetails
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
            this.btn_print = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.com_s_Class = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_s_AdmissionNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_s_studentname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_search = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(775, 176);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(66, 30);
            this.btn_print.TabIndex = 17;
            this.btn_print.Text = "print";
            this.btn_print.UseSelectable = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(119, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 191);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // com_s_Class
            // 
            this.com_s_Class.FormattingEnabled = true;
            this.com_s_Class.ItemHeight = 23;
            this.com_s_Class.Location = new System.Drawing.Point(720, 102);
            this.com_s_Class.Name = "com_s_Class";
            this.com_s_Class.Size = new System.Drawing.Size(121, 29);
            this.com_s_Class.TabIndex = 15;
            this.com_s_Class.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(662, 108);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Class:";
            // 
            // txt_s_AdmissionNo
            // 
            // 
            // 
            // 
            this.txt_s_AdmissionNo.CustomButton.Image = null;
            this.txt_s_AdmissionNo.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txt_s_AdmissionNo.CustomButton.Name = "";
            this.txt_s_AdmissionNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_s_AdmissionNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_s_AdmissionNo.CustomButton.TabIndex = 1;
            this.txt_s_AdmissionNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_s_AdmissionNo.CustomButton.UseSelectable = true;
            this.txt_s_AdmissionNo.CustomButton.Visible = false;
            this.txt_s_AdmissionNo.Lines = new string[0];
            this.txt_s_AdmissionNo.Location = new System.Drawing.Point(471, 108);
            this.txt_s_AdmissionNo.MaxLength = 32767;
            this.txt_s_AdmissionNo.Name = "txt_s_AdmissionNo";
            this.txt_s_AdmissionNo.PasswordChar = '\0';
            this.txt_s_AdmissionNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_s_AdmissionNo.SelectedText = "";
            this.txt_s_AdmissionNo.SelectionLength = 0;
            this.txt_s_AdmissionNo.SelectionStart = 0;
            this.txt_s_AdmissionNo.ShortcutsEnabled = true;
            this.txt_s_AdmissionNo.Size = new System.Drawing.Size(121, 23);
            this.txt_s_AdmissionNo.TabIndex = 13;
            this.txt_s_AdmissionNo.UseSelectable = true;
            this.txt_s_AdmissionNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_s_AdmissionNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(363, 108);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Admission No:";
            // 
            // txt_s_studentname
            // 
            // 
            // 
            // 
            this.txt_s_studentname.CustomButton.Image = null;
            this.txt_s_studentname.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txt_s_studentname.CustomButton.Name = "";
            this.txt_s_studentname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_s_studentname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_s_studentname.CustomButton.TabIndex = 1;
            this.txt_s_studentname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_s_studentname.CustomButton.UseSelectable = true;
            this.txt_s_studentname.CustomButton.Visible = false;
            this.txt_s_studentname.Lines = new string[0];
            this.txt_s_studentname.Location = new System.Drawing.Point(189, 108);
            this.txt_s_studentname.MaxLength = 32767;
            this.txt_s_studentname.Name = "txt_s_studentname";
            this.txt_s_studentname.PasswordChar = '\0';
            this.txt_s_studentname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_s_studentname.SelectedText = "";
            this.txt_s_studentname.SelectionLength = 0;
            this.txt_s_studentname.SelectionStart = 0;
            this.txt_s_studentname.ShortcutsEnabled = true;
            this.txt_s_studentname.Size = new System.Drawing.Size(121, 23);
            this.txt_s_studentname.TabIndex = 11;
            this.txt_s_studentname.UseSelectable = true;
            this.txt_s_studentname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_s_studentname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(71, 109);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Student Name:";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Blue;
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(908, 108);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "Search";
            this.btn_search.UseSelectable = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // FrmStudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 515);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.com_s_Class);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txt_s_AdmissionNo);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_s_studentname);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btn_search);
            this.Name = "FrmStudentDetails";
            this.Text = "FrmStudentDetails";
            this.Load += new System.EventHandler(this.FrmStudentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_print;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroComboBox com_s_Class;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_s_AdmissionNo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_s_studentname;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btn_search;
    }
}