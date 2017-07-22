using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace SchoolApp
{
    public partial class FrmMain : MetroFramework.Forms.MetroForm
    {
        static FrmMain _instance;

        public static FrmMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmMain();
                return _instance;
            }
        }

        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get { return mPanel1; }
            set { mPanel1 = value;  }
        }

        public MetroFramework.Controls.MetroLink MetroBack
        {
            get { return mback;  }
            set { mback = value; }

        }
        static string connectionString = ConfigurationManager.ConnectionStrings["SchoolApp.Properties.Settings.Setting"].ConnectionString;
        private OleDbConnection connection = new OleDbConnection(connectionString);
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            mback.Visible = false;
            _instance = this;
            UcDashboard uc = new UcDashboard();
            uc.Dock = DockStyle.Fill;
            mPanel1.Controls.Add(uc);

           // FormBorderStyle = FormBorderStyle.Sizable;
           // WindowState = FormWindowState.Maximized;
            //TopMost = true;

        }

        private void mback_Click(object sender, EventArgs e)
        {
            mPanel1.Controls["UcDashboard"].BringToFront();
            mback.Visible = false;
        }
    }
}
