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
    public partial class ucTransport : MetroFramework.Controls.MetroUserControl
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["SchoolApp.Properties.Settings.Setting"].ConnectionString;
        private OleDbConnection connection = new OleDbConnection(connectionString);
        public ucTransport()
        {
            InitializeComponent();
        }

        private void btn_addtransport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_transportroute.Text) || string.IsNullOrEmpty(txt_transportprice.Text))
            {
                MessageBox.Show("Enter all Value");
            }
            else
            { 
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "Insert into Transport (TransportRoute , TransportPrice) values ('"+txt_transportroute.Text+"' , '"+txt_transportprice.Text+"')";
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
