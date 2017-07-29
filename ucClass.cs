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
    public partial class ucClass : MetroFramework.Controls.MetroUserControl
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["SchoolApp.Properties.Settings.Setting"].ConnectionString;
        private OleDbConnection connection = new OleDbConnection(connectionString);
        Dictionary<int, string> myDictionary2 = new Dictionary<int, string>();
       
        public ucClass()
        {
            InitializeComponent();
        }

        private void btn_addclass_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txt_classname.Text))
                {
                    MessageBox.Show("Enter the Standard Name");
                }
                else
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;

                    string sql = "Insert into Class (ClassName) values ('" + txt_classname.Text + "')";
                   
                    command.CommandText = sql;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data saved");
                  
                    connection.Close();
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ucClass_Load(object sender, EventArgs e)
        {
            classandSection();
        }

        private void btn_AddClassSection_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(com_classname.Text) || string.IsNullOrEmpty(txt_sectionname.Text))
            {
                MessageBox.Show("Enter all man");
            }
            else
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                   
                    int value;
                    value = myDictionary2.FirstOrDefault(x => x.Value == com_classname.Text).Key;
                    command.CommandText = "Insert into Classandsection ([ClassID] , [Class] , [Section]) values ('" + Convert.ToString(value) + "' , '" + com_classname.Text + "' , '" + txt_sectionname.Text + "')";
                    command.ExecuteNonQuery();
                    myDictionary2.Clear();
                    MessageBox.Show("Data saved");
                    
                    connection.Close();
                    classandSection();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        private void com_classname_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void com_classname_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;
                command1.CommandText = "SELECT ClassID , ClassName from Class";
                OleDbDataReader reader = command1.ExecuteReader();

                while (reader.Read())
                {
                    myDictionary2.Add(reader.GetInt32(0), reader.GetString(1));
                    com_classname.DataSource = new BindingSource(myDictionary2, null);
                    com_classname.DisplayMember = "Value";
                    com_classname.ValueMember = "Key";
                }
                connection.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        public void classandSection()
        {
            try
            {
                List<ClassandSection> queryResults = new List<ClassandSection>();
                connection.Open();
                OleDbCommand command5 = new OleDbCommand();
                command5.Connection = connection;
                string clas5 = "Select [Class] , [Section] from [Classandsection]";
                command5.CommandText = clas5;
                using (var myReader = command5.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        queryResults.Add(new ClassandSection
                        {
                            classname = myReader.GetString(myReader.GetOrdinal("Class")),
                            Section = myReader.GetString(myReader.GetOrdinal("Section"))
                        });
                    }
                }
                this.dataGridView1.DataSource = queryResults;
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
