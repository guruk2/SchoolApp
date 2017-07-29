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
    public partial class ucTransport : MetroFramework.Controls.MetroUserControl
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["SchoolApp.Properties.Settings.Setting"].ConnectionString;
        private OleDbConnection connection = new OleDbConnection(connectionString);
        public ucTransport()
        {
            InitializeComponent();
        }

        private void btn_addtransport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_transportroute.Text) || string.IsNullOrEmpty(txt_transportprice.Text))
            {
                MessageBox.Show("Enter all Value");
            }
            else
            { 
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "Insert into Transport (TransportRoute , TransportPrice) values ('"+txt_transportroute.Text+"' , '"+txt_transportprice.Text+"')";
                    command.ExecuteNonQuery();
                   
                    MessageBox.Show("Data saved");
                    connection.Close();
                    transport();

                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        private void ucTransport_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 8, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            transport();
        }
        public void transport()
        {
            try
            {
                List<transport> queryResults = new List<transport>();
                connection.Open();
                OleDbCommand command5 = new OleDbCommand();
                command5.Connection = connection;
                string clas5 = "Select [TransportRoute] , [TransportPrice] from [Transport]";
                command5.CommandText = clas5;
                using (var myReader = command5.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        queryResults.Add(new transport
                        {
                            TransportRoute = myReader.GetString(myReader.GetOrdinal("TransportRoute")),
                            Price = myReader.GetString(myReader.GetOrdinal("TransportPrice"))
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
