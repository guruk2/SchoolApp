using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp
{
    public partial class Test : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["SchoolApp.Properties.Settings.Setting"].ConnectionString;
        private OleDbConnection connection = new OleDbConnection(connectionString);
       
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Cast' table. You can move, or remove it, as needed.
           Load1();

        }
        public void Load1()
        {
            List<Cast> queryResults = new List<Cast>();
            // Get a list of recently added users from the database.
            connection.Open();
            OleDbCommand command5 = new OleDbCommand();
            command5.Connection = connection;
            string clas5 = "Select [CastID] , [CastName] from [Cast]";
            command5.CommandText = clas5;
            using (var myReader = command5.ExecuteReader())
            {
                while (myReader.Read())
                {
                    queryResults.Add(new Cast
                    {
                        Id = Convert.ToString(myReader.GetInt32(myReader.GetOrdinal("CastID"))),
                        Name = myReader.GetString(myReader.GetOrdinal("CastName"))
                    });
                }
            }

            this.dataGridView1.DataSource = queryResults;

            
            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
