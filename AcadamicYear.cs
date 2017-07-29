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
    public partial class AcadamicYear : MetroFramework.Forms.MetroForm
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["SchoolApp.Properties.Settings.Setting"].ConnectionString;
        private OleDbConnection connection = new OleDbConnection(connectionString);
        public AcadamicYear()
        {
            InitializeComponent();
        }

        private void btn_AddAcadamic_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "Insert into AcadamicYear ([Acadamicdate]) values ('"+txt_year.Text+"')";
                command.ExecuteNonQuery();
                MessageBox.Show("Year saved");
                connection.Close();
                
                Login l = new Login();
                l.ShowDialog();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }
    }
}
