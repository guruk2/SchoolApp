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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["SchoolApp.Properties.Settings.Setting"].ConnectionString;
        private OleDbConnection connection = new OleDbConnection(connectionString);
        public Login()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {           
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txt_username.Text) || string.IsNullOrEmpty(txt_password.Text))
                {
                    MessageBox.Show("Enter all mandatory fields");
                }
                else
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "select * from Login where Username = '" + txt_username.Text + "' and Password = '" + txt_password.Text + "'";
                    OleDbDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        connection.Close();
                        connection.Dispose();
                        this.Hide();
                        FrmMain f = new FrmMain();
                        f.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Incorrect Details");
                        connection.Close();
                    }

                    connection.Close();

                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select Acadamicdate from AcadamicYear";
                OleDbDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    connection.Close();
                    AcadamicYear a = new AcadamicYear();
                    a.ShowDialog();
                }
                connection.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }
    }
}
