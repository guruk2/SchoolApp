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
    public partial class ClassReport : MetroFramework.Forms.MetroForm
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["SchoolApp.Properties.Settings.Setting"].ConnectionString;
        private OleDbConnection connection = new OleDbConnection(connectionString);
        public ClassReport()
        {
            InitializeComponent();
        }

        private void ClassReport_Load(object sender, EventArgs e)
        {
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
            reportViewer1.LocalReport.DataSources.Clear(); //clear report

            reportViewer1.LocalReport.ReportEmbeddedResource = "SchoolApp.Classreport.rdlc";
            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("ClassDS", queryResults);
            reportViewer1.LocalReport.DataSources.Add(dataset);

            dataset.Value = queryResults;
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();



        }
    }
}
