using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp
{
    public partial class UcDashboard : MetroFramework.Controls.MetroUserControl
    {
        public UcDashboard()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Test uc = new Test();
               uc.Show();
            
             


        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            if (!FrmMain.Instance.MetroContainer.Controls.ContainsKey("ucClass"))
            {
                ucClass uc = new ucClass();
                uc.Dock = DockStyle.Fill;
                
                FrmMain.Instance.MetroContainer.Controls.Add(uc);
            }
            FrmMain.Instance.MetroContainer.Controls["ucClass"].BringToFront();
            FrmMain.Instance.MetroBack.Visible = true;
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            if (!FrmMain.Instance.MetroContainer.Controls.ContainsKey("ucFee"))
            {
                ucFee uc = new ucFee();
                uc.Dock = DockStyle.Fill;
                FrmMain.Instance.MetroContainer.Controls.Add(uc);
            }
            FrmMain.Instance.MetroContainer.Controls["ucFee"].BringToFront();
            FrmMain.Instance.MetroBack.Visible = true;
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            if (!FrmMain.Instance.MetroContainer.Controls.ContainsKey("ucTransport"))
            {
                ucTransport uc = new ucTransport();
                uc.Dock = DockStyle.Fill;
                FrmMain.Instance.MetroContainer.Controls.Add(uc);
            }
            FrmMain.Instance.MetroContainer.Controls["ucTransport"].BringToFront();
            FrmMain.Instance.MetroBack.Visible = true;
        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            if (!FrmMain.Instance.MetroContainer.Controls.ContainsKey("usReligion"))
            {
                usReligion uc = new usReligion();
                uc.Dock = DockStyle.Fill;
                FrmMain.Instance.MetroContainer.Controls.Add(uc);
            }
            FrmMain.Instance.MetroContainer.Controls["usReligion"].BringToFront();
            FrmMain.Instance.MetroBack.Visible = true;
        }
    }
}
