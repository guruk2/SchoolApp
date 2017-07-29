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
using System.IO;


namespace SchoolApp
{
    public partial class EditStudent : MetroFramework.Forms.MetroForm
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["SchoolApp.Properties.Settings.Setting"].ConnectionString;
        private OleDbConnection connection = new OleDbConnection(connectionString);
        Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        Dictionary<int, string> myDictionary3 = new Dictionary<int, string>();
        string AcadamicYear;
        string AdmissionDate;
        string SectionClass;
        string Classna;
        string PreviousSchoolName;
        string LastResult;
        string SpecialNote;
        string StudentName;
        string FatherName;
        string MotherName;
        string Gender;
        string DOB;
        string PresentAddress;
        string PermanentAddress;
        string Nationality;
        string Cast;
        string BloodGroup;
        string ContactNumber;
        string Religion;
        string TransportRoute;
        string Heightstudent;
        string Weight;
        string FatherOccupation;
        string FatherSalary;
        string AdmissionID;
        int cid;
        FrmStudentDetails _f2;
        public EditStudent(FrmStudentDetails f2_)
        {
            InitializeComponent();
            this._f2 = f2_;
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;
                string clas = "SELECT ClassID , ClassName from Class";
                command1.CommandText = clas;
                OleDbDataReader reader9 = command1.ExecuteReader();

                while (reader9.Read())
                {

                    myDictionary.Add(reader9.GetInt32(0), reader9.GetString(1));
                    com_class.DataSource = new BindingSource(myDictionary, null);
                    com_class.DisplayMember = "Value";
                    com_class.ValueMember = "Key";
                }

                OleDbCommand command2 = new OleDbCommand();
                command2.Connection = connection;
                string clas1 = "Select [ClassAndSectionID] , [Section] from Classandsection";
                command2.CommandText = clas1;
                OleDbDataReader reader1 = command2.ExecuteReader();
                Dictionary<int, string> myDictionary1 = new Dictionary<int, string>();
                while (reader1.Read())
                {
                    myDictionary1.Add(reader1.GetInt32(0), reader1.GetString(1));
                    com_Section.DataSource = new BindingSource(myDictionary1, null);
                    com_Section.DisplayMember = "Value";
                    com_Section.ValueMember = "Key";
                }

                OleDbCommand command3 = new OleDbCommand();
                command3.Connection = connection;
                string clas3 = "Select [TransportID] , [TransportRoute] from Transport";
                command3.CommandText = clas3;
                OleDbDataReader reader3 = command3.ExecuteReader();

                while (reader3.Read())
                {
                    myDictionary3.Add(reader3.GetInt32(0), reader3.GetString(1));
                    com_Transport.DataSource = new BindingSource(myDictionary3, null);
                    com_Transport.DisplayMember = "Value";
                    com_Transport.ValueMember = "Key";
                }

                OleDbCommand command4 = new OleDbCommand();
                command4.Connection = connection;
                string clas4 = "Select [ReligionID] , [ReligionName] from Religion";
                command4.CommandText = clas4;
                OleDbDataReader reader4 = command4.ExecuteReader();
                Dictionary<int, string> myDictionary4 = new Dictionary<int, string>();
                while (reader4.Read())
                {
                    myDictionary4.Add(reader4.GetInt32(0), reader4.GetString(1));
                    com_Religion.DataSource = new BindingSource(myDictionary4, null);
                    com_Religion.DisplayMember = "Value";
                    com_Religion.ValueMember = "Key";
                }

                OleDbCommand command5 = new OleDbCommand();
                command5.Connection = connection;
                string clas5 = "Select [CastID] , [CastName] from [Cast]";
                command5.CommandText = clas5;
                OleDbDataReader reader5 = command5.ExecuteReader();
                Dictionary<int, string> myDictionary5 = new Dictionary<int, string>();
                while (reader5.Read())
                {
                    myDictionary5.Add(reader5.GetInt32(0), reader5.GetString(1));
                    com_Cast.DataSource = new BindingSource(myDictionary5, null);
                    com_Cast.DisplayMember = "Value";
                    com_Cast.ValueMember = "Key";
                }

                OleDbCommand command6 = new OleDbCommand();
                command6.Connection = connection;
                command6.CommandText = "select Acadamicdate from AcadamicYear";
                OleDbDataReader read = command6.ExecuteReader();
                while (read.Read())
                {
                    label_acadamicyear.Text = read.GetString(0);
                }

                OleDbCommand command9 = new OleDbCommand();
                command9.Connection = connection;
                command9.CommandText = "select * from [StudentDetails] where  [AdmissionID] = '" + this._f2.Ed + "'";
                OleDbDataReader reader = command9.ExecuteReader();
                while (reader.Read())
                {
                    AdmissionID = reader.GetValue(1).ToString(); lb_AdmissionID.Text = AdmissionID;

                    AcadamicYear = reader.GetValue(5).ToString(); label_acadamicyear.Text = AcadamicYear;
                    AdmissionDate = reader.GetValue(6).ToString(); txt_Admission_date.Text = AdmissionDate;
                    // AdmissionDate = Convert.ToDateTime(reader["AdmissionDate"]).ToString("dd/MM/yyyy");
                    SectionClass = reader.GetValue(7).ToString(); com_Section.Text = SectionClass;
                    Classna = reader.GetValue(8).ToString(); com_class.Text = Classna;
                    PreviousSchoolName = reader.GetValue(9).ToString(); txt_preSchoolName.Text = PreviousSchoolName;
                    LastResult = reader.GetValue(10).ToString(); txt_lastResult.Text = LastResult;
                    SpecialNote = reader.GetValue(11).ToString(); txt_SpecialNote.Text = SpecialNote;
                    StudentName = reader.GetValue(12).ToString(); txt_StudentName.Text = StudentName;
                    FatherName = reader.GetValue(13).ToString(); txt_fathersname.Text = FatherName;
                    MotherName = reader.GetValue(14).ToString(); txt_MotherName.Text = MotherName;
                    Gender = reader.GetValue(15).ToString(); com_gender.Text = Gender;
                    DOB = reader.GetValue(16).ToString(); txt_DOB.Text = DOB;
                    PresentAddress = reader.GetValue(17).ToString(); txt_PresentAddress.Text = PresentAddress;
                    PermanentAddress = reader.GetValue(18).ToString(); txt_PermanentAddress.Text = PermanentAddress;
                    Nationality = reader.GetValue(19).ToString(); txt_Nationality.Text = Nationality;
                    Cast = reader.GetValue(20).ToString(); com_Cast.Text = Cast;
                    BloodGroup = reader.GetValue(21).ToString(); com_BloodGroup.Text = BloodGroup;
                    ContactNumber = reader.GetValue(22).ToString(); txt_Contact.Text = ContactNumber;
                    Religion = reader.GetValue(23).ToString(); com_Religion.Text = Religion;
                    TransportRoute = reader.GetValue(24).ToString(); com_Transport.Text = TransportRoute;
                    Heightstudent = reader.GetValue(25).ToString(); txt_Height.Text = Heightstudent;
                    Weight = reader.GetValue(26).ToString(); txt_Weight.Text = Weight;
                    FatherOccupation = reader.GetValue(27).ToString(); txt_fatheroccupation.Text = FatherOccupation;
                    FatherSalary = reader.GetValue(28).ToString(); txt_fathersalary.Text = FatherSalary;

                }
                connection.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void btn_UpdateStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lb_AdmissionID.Text) || string.IsNullOrEmpty(txt_Admission_date.Text) || string.IsNullOrEmpty(com_class.Text) || string.IsNullOrEmpty(com_Section.Text) || string.IsNullOrEmpty(txt_StudentName.Text) || string.IsNullOrEmpty(txt_fathersname.Text) || string.IsNullOrEmpty(txt_MotherName.Text) || string.IsNullOrEmpty(com_gender.Text) || string.IsNullOrEmpty(txt_DOB.Text) || string.IsNullOrEmpty(txt_PresentAddress.Text) || string.IsNullOrEmpty(txt_Contact.Text))
            {
                MessageBox.Show("Enter All Values");
            }
            else
            {
                try
                {
                    connection.Open();
                    OleDbCommand command1 = new OleDbCommand();
                    command1.Connection = connection;

                    cid = myDictionary.FirstOrDefault(x => x.Value == com_class.Text).Key;
                    int tid;
                    tid = myDictionary3.FirstOrDefault(x => x.Value == com_Transport.Text).Key;
                    command1.CommandText = "update StudentDetails set [AdmissionDate] = ? ,[SectionClass] = ?,[Class] = ?,[PreviousSchoolName] = ?,[LastResult] = ?,[SpecialNote] = ?,[StudentName] = ?,[FatherName] = ?,[MotherName] = ?,[Gender] = ?,[DOB] = ?,[PresentAddress] = ?,[PermanentAddress] = ?,[Nationality] = ?,[Cast] = ?,[BloodGroup] = ?,[ContactNumber] = ?,[Religion] = ?,[TransportRoute] = ?,[Height] = ?,[Weight] = ?,[FatherOccupation] = ?,[FatherSalary] = ?,[ClassID] = ?,[TransportID] = ?,[AcadamicYear] =? where [AdmissionID] = '"+lb_AdmissionID.Text+"'";
                    command1.Parameters.AddWithValue("AdmissionDate", txt_Admission_date.Text);
                    command1.Parameters.AddWithValue("SectionClass", com_Section.Text);
                    command1.Parameters.AddWithValue("Class", com_class.Text);
                    command1.Parameters.AddWithValue("PreviousSchoolName", txt_preSchoolName.Text);
                    command1.Parameters.AddWithValue("LastResult", txt_lastResult.Text);
                    command1.Parameters.AddWithValue("SpecialNote", txt_SpecialNote.Text);
                    command1.Parameters.AddWithValue("StudentName", txt_StudentName.Text);
                    command1.Parameters.AddWithValue("FatherName", txt_fathersname.Text);
                    command1.Parameters.AddWithValue("MotherName", txt_MotherName.Text);
                    command1.Parameters.AddWithValue("Gender", com_gender.Text);
                    command1.Parameters.AddWithValue("DOB", txt_DOB.Text);
                    command1.Parameters.AddWithValue("PresentAddress", txt_PresentAddress.Text);
                    command1.Parameters.AddWithValue("PermanentAddress", txt_PermanentAddress.Text);
                    command1.Parameters.AddWithValue("Nationality", txt_Nationality.Text);
                    command1.Parameters.AddWithValue("Cast", com_Cast.Text);
                    command1.Parameters.AddWithValue("BloodGroup", com_BloodGroup.Text);
                    command1.Parameters.AddWithValue("ContactNumber", txt_Contact.Text);
                    command1.Parameters.AddWithValue("Religion", com_Religion.Text);
                    command1.Parameters.AddWithValue("TransportRoute", com_Transport.Text);
                    command1.Parameters.AddWithValue("Height", txt_Height.Text);
                    command1.Parameters.AddWithValue("Weight", txt_Weight.Text);
                    command1.Parameters.AddWithValue("FatherOccupation", txt_fatheroccupation.Text);
                    command1.Parameters.AddWithValue("FatherSalary", txt_fathersalary.Text);
                    
                    command1.Parameters.AddWithValue("ClassID", Convert.ToString(cid));
                    command1.Parameters.AddWithValue("TransportID", Convert.ToString(tid));
                    
                    command1.Parameters.AddWithValue("AcadamicYear", label_acadamicyear.Text);
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Data updated");
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

