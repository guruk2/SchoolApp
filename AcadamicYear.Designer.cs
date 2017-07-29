namespace SchoolApp
{
    partial class AcadamicYear
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_year = new MetroFramework.Controls.MetroDateTime();
            this.btn_AddAcadamic = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(22, 138);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(147, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Enter Acadamic Year";
            // 
            // txt_year
            // 
            this.txt_year.CustomFormat = "yyyy";
            this.txt_year.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_year.Location = new System.Drawing.Point(175, 133);
            this.txt_year.MinimumSize = new System.Drawing.Size(0, 29);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(66, 29);
            this.txt_year.TabIndex = 1;
            // 
            // btn_AddAcadamic
            // 
            this.btn_AddAcadamic.Location = new System.Drawing.Point(133, 200);
            this.btn_AddAcadamic.Name = "btn_AddAcadamic";
            this.btn_AddAcadamic.Size = new System.Drawing.Size(75, 23);
            this.btn_AddAcadamic.TabIndex = 2;
            this.btn_AddAcadamic.Text = "Add";
            this.btn_AddAcadamic.UseSelectable = true;
            this.btn_AddAcadamic.Click += new System.EventHandler(this.btn_AddAcadamic_Click);
            // 
            // AcadamicYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 310);
            this.Controls.Add(this.btn_AddAcadamic);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AcadamicYear";
            this.Text = "AcadamicYear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime txt_year;
        private MetroFramework.Controls.MetroButton btn_AddAcadamic;
    }
}