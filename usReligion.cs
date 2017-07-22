using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace SchoolApp
{
    public partial class usReligion : MetroFramework.Controls.MetroUserControl
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["SchoolApp.Properties.Settings.Setting"].ConnectionString;
        private OleDbConnection connection = new OleDbConnection(connectionString);
        public usReligion()
        {
            InitializeComponent();
        }

        private void btn_addreligion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Religion.Text))
            {
                MessageBox.Show("Enter the value");
            }
            else
            { 
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "Insert into Religion (ReligionName) values ('"+txt_Religion.Text+"')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data saved");
                    connection.Close();

                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        private void btn_addCast_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cast.Text))
            {
                MessageBox.Show("Enter the value");
            }
            else
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "Insert into [Cast] (CastName) values ('" + txt_cast.Text + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data saved");
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
}
