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
    public partial class ucFee : MetroFramework.Controls.MetroUserControl
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["SchoolApp.Properties.Settings.Setting"].ConnectionString;
        private OleDbConnection connection = new OleDbConnection(connectionString);
        Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        Dictionary<int, string> myDictionary2 = new Dictionary<int, string>();
        public ucFee()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_addexpense_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_expensestype.Text))
            {
                MessageBox.Show("Enter the value");
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
                    string sql = "Insert into ExpenseCategory (ExpenseType , ClassID) values ('" + txt_expensestype.Text + "' , '"+ Convert.ToString(value) + "')";
                    command.CommandText = sql;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data saved");

                    connection.Close();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        private void ucFee_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
               
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;
                command1.CommandText = "SELECT ClassID , ClassName from Class";
                OleDbDataReader reader1 = command1.ExecuteReader();
               
                while (reader1.Read())
                {
                    myDictionary2.Add(reader1.GetInt32(0), reader1.GetString(1));
                    com_classname.DataSource = new BindingSource(myDictionary2, null);
                    com_classname.DisplayMember = "Value";
                    com_classname.ValueMember = "Key";
                }

                connection.Close();
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
                dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 8, FontStyle.Bold);
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView1.EnableHeadersVisualStyles = false;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            Expense();
        }

        private void btn_addexpensepayment_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(com_expensetype.Text) || (string.IsNullOrEmpty(txt_expenseamount.Text)))
            {
                MessageBox.Show("Enter all value");
            }
            else
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    int value;
                    value = myDictionary.FirstOrDefault(x => x.Value == com_expensetype.Text).Key;
                    command.CommandText = "Insert into ExpensePayment (ExpenseCategoryID, ExpenseType , ExpensePrice) values ('" + Convert.ToString(value) + "' , '" + com_expensetype.Text + "' , '" +txt_expenseamount.Text + "')";
                    command.ExecuteNonQuery();
                    myDictionary.Clear();
                    MessageBox.Show("Data saved");
                    connection.Close();
                    Expense();
                }
                catch(OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void com_expensetype_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string sql1 = "Select ExpenseCategoryID , ExpenseType from ExpenseCategory";
                command.CommandText = sql1;
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    myDictionary.Add(reader.GetInt32(0), reader.GetString(1));
                    com_expensetype.DataSource = new BindingSource(myDictionary, null);
                    com_expensetype.DisplayMember = "Value";
                    com_expensetype.ValueMember = "Key";
                }
                connection.Close();
            }
            catch(OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            }

        public void Expense()
            {
            try
            {
                List<Expense> queryResults = new List<Expense>();
                connection.Open();
                OleDbCommand command5 = new OleDbCommand();
                command5.Connection = connection;
                string clas5 = "Select [ExpenseType] , [ExpensePrice] from [ExpensePayment]";
                command5.CommandText = clas5;
                using (var myReader = command5.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        queryResults.Add(new Expense
                        {
                            Category = myReader.GetString(myReader.GetOrdinal("ExpenseType")),
                            Price = myReader.GetString(myReader.GetOrdinal("ExpensePrice"))
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
