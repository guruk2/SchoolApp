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
using System.IO;

namespace SchoolApp
{
    public partial class ucAddStudent : MetroFramework.Controls.MetroUserControl
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["SchoolApp.Properties.Settings.Setting"].ConnectionString;
        private OleDbConnection connection = new OleDbConnection(connectionString);
        Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        Dictionary<int, string> myDictionary3 = new Dictionary<int, string>();
        string picPath;
        public ucAddStudent()
        {
            InitializeComponent();
            this.Refresh();
            Application.DoEvents();

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel12_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog dig = new OpenFileDialog();
            dig.Filter = " JPG Files(*.jpg)|*.jpg| PNG Files(*.png)|*.png|All File(*.*)|*.* ";

            if(dig.ShowDialog() == DialogResult.OK)
            {
                picPath = dig.FileName.ToString();
                pictureBox1.ImageLocation = picPath;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_Admission_no.Text) || string.IsNullOrEmpty(txt_Admission_date.Text) || string.IsNullOrEmpty(com_class.Text) || string.IsNullOrEmpty(com_Section.Text) || string.IsNullOrEmpty(txt_StudentName.Text) || string.IsNullOrEmpty(txt_fathersname.Text) || string.IsNullOrEmpty(txt_MotherName.Text) || string.IsNullOrEmpty(com_gender.Text) || string.IsNullOrEmpty(txt_DOB.Text) || string.IsNullOrEmpty(txt_PresentAddress.Text) || string.IsNullOrEmpty(txt_Contact.Text))
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
                    int cid;
                    cid = myDictionary.FirstOrDefault(x => x.Value == com_class.Text).Key ;
                    int tid;
                    tid = myDictionary3.FirstOrDefault(x => x.Value == com_Transport.Text).Key;
                    byte[] bt = null;
                    FileStream fstream = new FileStream(this.picPath, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fstream);
                    bt = br.ReadBytes((int)fstream.Length);
                    command1.CommandText = "Insert into StudentDetails ([AdmissionDate],[SectionClass],[Class],[PreviousSchoolName],[LastResult],[SpecialNote],[StudentName],[FatherName],[MotherName],[Gender],[DOB],[PresentAddress],[PermanentAddress],[Nationality],[Cast],[BloodGroup],[ContactNumber],[Religion],[TransportRoute],[Height],[Weight],[FatherOccupation],[FatherSalary],[AdmissionID],[ClassID],[TransportID],[StudentImage]) values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,@img)";
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
                    command1.Parameters.AddWithValue("AdmissionID", txt_Admission_no.Text);
                    command1.Parameters.AddWithValue("ClassID", Convert.ToString(cid));
                    command1.Parameters.AddWithValue("TransportID", Convert.ToString(tid));
                    command1.Parameters.AddWithValue("@img", bt);
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Data Saved");
                    connection.Close();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        private void ucAddStudent_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show("hi");
            try
            {
                connection.Open();
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;
                string clas = "SELECT ClassID , ClassName from Class";
                command1.CommandText = clas;
                OleDbDataReader reader = command1.ExecuteReader();
                
                while (reader.Read())
                {
                    MessageBox.Show(reader.GetString(1));
                    myDictionary.Add(reader.GetInt32(0), reader.GetString(1));
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
                Dictionary<int, string> myDictionary4= new Dictionary<int, string>();
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

                connection.Close();
            }
            catch(OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
