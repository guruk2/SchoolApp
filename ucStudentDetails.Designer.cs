namespace SchoolApp
{
    partial class ucStudentDetails
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
            this.btn_search = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_s_studentname = new MetroFramework.Controls.MetroTextBox();
            this.txt_s_AdmissionNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.com_s_Class = new MetroFramework.Controls.MetroComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_print = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(852, 41);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "Search";
            this.btn_search.UseSelectable = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(34, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Student Name:";
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
            this.txt_s_studentname.Location = new System.Drawing.Point(133, 41);
            this.txt_s_studentname.MaxLength = 32767;
            this.txt_s_studentname.Name = "txt_s_studentname";
            this.txt_s_studentname.PasswordChar = '\0';
            this.txt_s_studentname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_s_studentname.SelectedText = "";
            this.txt_s_studentname.SelectionLength = 0;
            this.txt_s_studentname.SelectionStart = 0;
            this.txt_s_studentname.ShortcutsEnabled = true;
            this.txt_s_studentname.Size = new System.Drawing.Size(121, 23);
            this.txt_s_studentname.TabIndex = 2;
            this.txt_s_studentname.UseSelectable = true;
            this.txt_s_studentname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_s_studentname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txt_s_AdmissionNo.Location = new System.Drawing.Point(415, 41);
            this.txt_s_AdmissionNo.MaxLength = 32767;
            this.txt_s_AdmissionNo.Name = "txt_s_AdmissionNo";
            this.txt_s_AdmissionNo.PasswordChar = '\0';
            this.txt_s_AdmissionNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_s_AdmissionNo.SelectedText = "";
            this.txt_s_AdmissionNo.SelectionLength = 0;
            this.txt_s_AdmissionNo.SelectionStart = 0;
            this.txt_s_AdmissionNo.ShortcutsEnabled = true;
            this.txt_s_AdmissionNo.Size = new System.Drawing.Size(121, 23);
            this.txt_s_AdmissionNo.TabIndex = 4;
            this.txt_s_AdmissionNo.UseSelectable = true;
            this.txt_s_AdmissionNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_s_AdmissionNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(316, 41);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(94, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Admission No:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(617, 41);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Class:";
            // 
            // com_s_Class
            // 
            this.com_s_Class.FormattingEnabled = true;
            this.com_s_Class.ItemHeight = 23;
            this.com_s_Class.Location = new System.Drawing.Point(664, 35);
            this.com_s_Class.Name = "com_s_Class";
            this.com_s_Class.Size = new System.Drawing.Size(121, 29);
            this.com_s_Class.TabIndex = 6;
            this.com_s_Class.UseSelectable = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(164, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 191);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(719, 109);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(66, 30);
            this.btn_print.TabIndex = 8;
            this.btn_print.Text = "print";
            this.btn_print.UseSelectable = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // ucStudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.com_s_Class);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txt_s_AdmissionNo);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_s_studentname);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btn_search);
            this.Name = "ucStudentDetails";
            this.Size = new System.Drawing.Size(1077, 391);
            this.Load += new System.EventHandler(this.ucStudentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_search;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_s_studentname;
        private MetroFramework.Controls.MetroTextBox txt_s_AdmissionNo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox com_s_Class;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btn_print;
    }
}
