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
    public partial class ucClassData : MetroFramework.Controls.MetroUserControl
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["SchoolApp.Properties.Settings.Setting"].ConnectionString;
        private OleDbConnection connection = new OleDbConnection(connectionString);
        public ucClassData()
        {
           
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void Classload()
        {
           // MessageBox.Show("hi");
            List<Class> queryResults = new List<Class>();
            // Get a list of recently added users from the database.
            connection.Open();
            OleDbCommand command5 = new OleDbCommand();
            command5.Connection = connection;
            string clas5 = "Select [ClassName] , [NFStudent] from [Class]";
            command5.CommandText = clas5;
            using (var myReader = command5.ExecuteReader())
            {
                while (myReader.Read())
                {
                    queryResults.Add(new Class
                    {
                        NoOFStudent = Convert.ToString(myReader.GetInt32(myReader.GetOrdinal("NFStudent"))),
                        
                        ClassName = myReader.GetString(myReader.GetOrdinal("ClassName"))
                    });
                   
                }
            }
            
            this.dataGridView1.DataSource = queryResults;
            connection.Close();

        }

        private void ucClassData_Load(object sender, EventArgs e)
        {
            Classload();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ClassReport c = new ClassReport();
            c.ShowDialog();
        }
    }
}
