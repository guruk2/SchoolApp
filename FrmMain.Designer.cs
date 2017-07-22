namespace SchoolApp
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mback = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // mPanel1
            // 
            this.mPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mPanel1.HorizontalScrollbarBarColor = true;
            this.mPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel1.HorizontalScrollbarSize = 10;
            this.mPanel1.Location = new System.Drawing.Point(23, 63);
            this.mPanel1.Name = "mPanel1";
            this.mPanel1.Size = new System.Drawing.Size(672, 353);
            this.mPanel1.TabIndex = 1;
            this.mPanel1.VerticalScrollbarBarColor = true;
            this.mPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel1.VerticalScrollbarSize = 10;
            // 
            // mback
            // 
            this.mback.Image = ((System.Drawing.Image)(resources.GetObject("mback.Image")));
            this.mback.ImageSize = 32;
            this.mback.Location = new System.Drawing.Point(23, 20);
            this.mback.Name = "mback";
            this.mback.Size = new System.Drawing.Size(50, 37);
            this.mback.TabIndex = 2;
            this.mback.UseSelectable = true;
            this.mback.Click += new System.EventHandler(this.mback_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 439);
            this.Controls.Add(this.mback);
            this.Controls.Add(this.mPanel1);
            this.Name = "FrmMain";
            this.Text = "         School Management";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel mPanel1;
        private MetroFramework.Controls.MetroLink mback;
    }
}