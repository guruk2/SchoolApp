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
    public partial class FeeCollection : MetroFramework.Forms.MetroForm
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["SchoolApp.Properties.Settings.Setting"].ConnectionString;
        private OleDbConnection connection = new OleDbConnection(connectionString);
        List<feedata> queryResults = new List<feedata>();
        string a;
        string Classname;
        string section;
        string studentname;
        string fathername;
       
        ucStudentFee _f2;
        public FeeCollection(ucStudentFee f2_)
        {
            InitializeComponent();
            this._f2 = f2_;
        }

        private void FeeCollection_Load(object sender, EventArgs e)
        {
            DateTime noe = DateTime.Now;
            lb_todayyear.Text = noe.Year.ToString();
            lb_todaymonth.Text = noe.Month.ToString();
            lb_todayday.Text = noe.Day.ToString();
            lb_todaytime.Text = DateTime.Now.ToString("HH:mm:ss");
            try
            {
               
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "Select [AdmissionID], [Class], [SectionClass] ,[StudentName], [FatherName] from [StudentDetails] where [AdmissionID] = '" + this._f2.Sf+"' ";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    a = reader.GetValue(0).ToString(); lb_Admissionno.Text = a;
                    Classname = reader.GetValue(1).ToString(); lb_class.Text = Classname;
                    section = reader.GetValue(2).ToString(); lb_section.Text = section;
                    studentname = reader.GetValue(3).ToString(); lb_studentname.Text = studentname;
                    fathername = reader.GetValue(4).ToString(); lb_fathername.Text = fathername;
                }
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;
                command1.CommandText = "SELECT  T.TransportRoute, T.TransportPrice, P.ExpenseType, P.ExpensePrice, T.TransportID FROM ((StudentDetails S INNER JOIN ExpenseCategory C ON S.ClassID = C.ClassID) INNER JOIN ExpensePayment P ON C.ExpenseCategoryID = P.ExpenseCategoryID), Transport T WHERE        (S.AdmissionID ='" + this._f2.Sf + "' )"; // 
                OleDbDataReader myreader = command1.ExecuteReader();
                while (myreader.Read())
                {
                    queryResults.Add(new feedata

                    { 
                        Collection = myreader.GetString(myreader.GetOrdinal("TransportRoute")),
                        Price = myreader.GetString(myreader.GetOrdinal("TransportPrice"))

                    });
                    
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

        private void lb_todaydate_Click(object sender, EventArgs e)
        {

        }
    }
}
