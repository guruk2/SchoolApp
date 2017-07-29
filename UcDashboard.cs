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
            AddStudent a = new AddStudent();
            a.ShowDialog();

               /* ucAddStudent uc = new ucAddStudent();
                uc.Dock = DockStyle.Fill;
                FrmMain.Instance.MetroContainer.Controls.Add(uc);
            
            FrmMain.Instance.MetroContainer.Controls["ucAddStudent"].BringToFront();
            FrmMain.Instance.MetroBack.Visible = true;*/
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

        private void metroTile4_Click(object sender, EventArgs e)
        {
            FrmClassData cd = new FrmClassData();
            cd.ShowDialog();
            
            //    ucClassData uc = new ucClassData();
            //    uc.Dock = DockStyle.Fill;
            //    FrmMain.Instance.MetroContainer.Controls.Add(uc);
            
            //FrmMain.Instance.MetroContainer.Controls["ucClassData"].BringToFront();
            //FrmMain.Instance.MetroBack.Visible = true;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            FrmStudentDetails sd = new FrmStudentDetails();
            sd.ShowDialog();
            //ucStudentDetails uc = new ucStudentDetails();
            //uc.Dock = DockStyle.Fill;
            //FrmMain.Instance.MetroContainer.Controls.Add(uc);

            //FrmMain.Instance.MetroContainer.Controls["ucStudentDetails"].BringToFront();
            //FrmMain.Instance.MetroBack.Visible = true;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            ucStudentFee uc = new ucStudentFee();
            uc.Dock = DockStyle.Fill;
            FrmMain.Instance.MetroContainer.Controls.Add(uc);

            FrmMain.Instance.MetroContainer.Controls["ucStudentFee"].BringToFront();
            FrmMain.Instance.MetroBack.Visible = true;
        }

        private void UcDashboard_Load(object sender, EventArgs e)
        {

        }

        private void metroLink5_Click(object sender, EventArgs e)
        {

        }
    }
 }
