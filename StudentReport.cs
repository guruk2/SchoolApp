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
    public partial class StudentReport : MetroFramework.Forms.MetroForm
    {
        FrmStudentDetails _f2;
        static string connectionString = ConfigurationManager.ConnectionStrings["SchoolApp.Properties.Settings.Setting"].ConnectionString;
        private OleDbConnection connection = new OleDbConnection(connectionString);
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
        public StudentReport(FrmStudentDetails f2_)
        {
            InitializeComponent();
            this._f2 = f2_;
        }

        private void StudentReport_Load(object sender, EventArgs e)
        {
            try
            {
                List<Student> query = new List<Student>();
                connection.Open();
                OleDbCommand command5 = new OleDbCommand();
                command5.Connection = connection;
                string clas5 = "Select [StudentImage],[AcadamicYear],[AdmissionDate],[SectionClass],[Class],[PreviousSchoolName],[LastResult],[SpecialNote],[StudentName],[FatherName],[MotherName],[Gender],[DOB],[PresentAddress],[PermanentAddress],[Nationality],[Cast],[BloodGroup],[ContactNumber],[Religion],[TransportRoute],[Height],[Weight],[FatherOccupation],[FatherSalary],[AdmissionID] from [StudentDetails] where [AdmissionID] = '"+this._f2.Ad+"'";
                command5.CommandText = clas5;
                OleDbDataReader reader = command5.ExecuteReader();
                while(reader.Read())
                {
                   // AcadamicYear = reader.GetValue(0).ToString();
                    AcadamicYear = reader.GetValue(1).ToString();
                   // AdmissionDate = reader.GetValue(2).ToString();
                    AdmissionDate = Convert.ToDateTime(reader["AdmissionDate"]).ToString("dd/MM/yyyy");
                    SectionClass = reader.GetValue(3).ToString();
                    Classna = reader.GetValue(4).ToString();
                    PreviousSchoolName = reader.GetValue(5).ToString();
                    LastResult = reader.GetValue(6).ToString();
                    SpecialNote = reader.GetValue(7).ToString();
                    StudentName = reader.GetValue(8).ToString();
                    FatherName = reader.GetValue(9).ToString();
                    MotherName = reader.GetValue(10).ToString();
                    Gender = reader.GetValue(11).ToString();
                    DOB = reader.GetValue(12).ToString();
                    PresentAddress = reader.GetValue(13).ToString();
                    PermanentAddress = reader.GetValue(14).ToString();
                    Nationality = reader.GetValue(15).ToString();
                    Cast = reader.GetValue(16).ToString();
                    BloodGroup = reader.GetValue(17).ToString();
                    ContactNumber = reader.GetValue(18).ToString();
                    Religion = reader.GetValue(19).ToString();
                    TransportRoute = reader.GetValue(20).ToString();
                    Heightstudent = reader.GetValue(21).ToString();
                    Weight = reader.GetValue(22).ToString();
                    FatherOccupation = reader.GetValue(23).ToString();
                    FatherSalary = reader.GetValue(24).ToString();
                    AdmissionID = reader.GetValue(25).ToString();

                    query.Add(new Student
                    {
                        image = (Byte[])reader.GetValue(reader.GetOrdinal("StudentImage"))
                    });
                }
                Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
                 {

                        new Microsoft.Reporting.WinForms.ReportParameter("ADMISSIONID" ,  AdmissionID),
                        new Microsoft.Reporting.WinForms.ReportParameter("AcadamicYear" ,  AcadamicYear),
                        new Microsoft.Reporting.WinForms.ReportParameter("AdmissionDate" , AdmissionDate ),
                        new Microsoft.Reporting.WinForms.ReportParameter("SectionClass" ,  SectionClass),
                        new Microsoft.Reporting.WinForms.ReportParameter("Class" ,  Classna),
                        new Microsoft.Reporting.WinForms.ReportParameter("PreviousSchoolName" ,  PreviousSchoolName),
                        new Microsoft.Reporting.WinForms.ReportParameter("LastResult" , LastResult),
                        new Microsoft.Reporting.WinForms.ReportParameter("SpecialNote" ,  SpecialNote),
                        new Microsoft.Reporting.WinForms.ReportParameter("StudentName" ,  StudentName),
                        new Microsoft.Reporting.WinForms.ReportParameter("FatherName" ,  FatherName),
                        new Microsoft.Reporting.WinForms.ReportParameter("MotherName" ,  MotherName),
                        new Microsoft.Reporting.WinForms.ReportParameter("Gender" ,  Gender),
                        new Microsoft.Reporting.WinForms.ReportParameter("DOB" ,  DOB),
                        new Microsoft.Reporting.WinForms.ReportParameter("PresentAddress" ,  PresentAddress),
                        new Microsoft.Reporting.WinForms.ReportParameter("PermanentAddress" ,  PermanentAddress),
                        new Microsoft.Reporting.WinForms.ReportParameter("Nationality" , Nationality),
                        new Microsoft.Reporting.WinForms.ReportParameter("Cast" ,  Cast),
                        new Microsoft.Reporting.WinForms.ReportParameter("BloodGroup" ,  BloodGroup),
                        new Microsoft.Reporting.WinForms.ReportParameter("ContactNumber" ,  ContactNumber),
                        new Microsoft.Reporting.WinForms.ReportParameter("Religion" ,  Religion),
                       // new Microsoft.Reporting.WinForms.ReportParameter("student" ,  a.ToString()),
                        new Microsoft.Reporting.WinForms.ReportParameter("TransportRoute" ,  TransportRoute),
                        new Microsoft.Reporting.WinForms.ReportParameter("Height" ,  Heightstudent),
                        new Microsoft.Reporting.WinForms.ReportParameter("Weight" ,  Weight),
                        new Microsoft.Reporting.WinForms.ReportParameter("FatherOccupation" ,  FatherOccupation),
                        new Microsoft.Reporting.WinForms.ReportParameter("FatherSalary" ,  FatherSalary)
                 };
                reportViewer1.LocalReport.DataSources.Clear(); //clear report

                reportViewer1.LocalReport.ReportEmbeddedResource = "SchoolApp.StudentReport.rdlc";
                Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("StudentDS", query);
                reportViewer1.LocalReport.DataSources.Add(dataset);
                reportViewer1.LocalReport.SetParameters(p);
                dataset.Value = query;
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
                      
        }
    }
}
