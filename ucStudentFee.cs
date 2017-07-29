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
    public partial class ucStudentFee : MetroFramework.Controls.MetroUserControl
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["SchoolApp.Properties.Settings.Setting"].ConnectionString;
        private OleDbConnection connection = new OleDbConnection(connectionString);
        Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        public String Sf { get; set; }
   
        public ucStudentFee()
        {
            InitializeComponent();
        }

        private void ucStudentFee_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;
                string clas = "SELECT ClassID , ClassName from Class";
                command1.CommandText = clas;
                OleDbDataReader myreader = command1.ExecuteReader();

                while (myreader.Read())
                {

                    myDictionary.Add(myreader.GetInt32(0), myreader.GetString(1));
                    com_s_Class.DataSource = new BindingSource(myDictionary, null);
                    com_s_Class.DisplayMember = "Value";
                    com_s_Class.ValueMember = "Key";
                }
                connection.Close();
                load2();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                List<Studentdetails> queryResults = new List<Studentdetails>();
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "Select [AdmissionID], [Class], [StudentName], [FatherName] from [StudentDetails] where [StudentName] = '" + txt_s_studentname.Text + "' OR [AdmissionID] = '" + txt_s_AdmissionNo.Text + "' OR [Class] = '" + com_s_Class.Text + "'";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    queryResults.Add(new Studentdetails
                    {
                        // NoOFStudent = Convert.ToString(reader.GetInt32(reader.GetOrdinal("NFStudent"))),

                        studentname = reader.GetString(reader.GetOrdinal("StudentName")),
                        admissionid = reader.GetString(reader.GetOrdinal("AdmissionID")),
                        fathername = reader.GetString(reader.GetOrdinal("FatherName")),
                        classname = reader.GetString(reader.GetOrdinal("Class"))
                    });
                }

                this.dataGridView1.DataSource = queryResults;
                //dataGridView1.EnableHeadersVisualStyles = false;
                //dataGridView1.ColumnHeadersDefaultCellStyle = BlueDataGridHeaderStyle.GetInstance();
                connection.Close();
                
            }


            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        public void load2()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            //btn.HeaderText = "Pay Bill";
            btn.Text = "Edit";
            //btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                FeeCollection Fe = new FeeCollection(this);
                Sf = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                Fe.ShowDialog();
            }
        }
    }
}
