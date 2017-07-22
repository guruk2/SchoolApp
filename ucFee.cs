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

                    string sql = "Insert into ExpenseCategory (ExpenseType) values ('" + txt_expensestype.Text + "')";
                    command.CommandText = sql;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data saved");

                    string sql1 = "Select ExpenseCategoryID , ExpenseType from ExpenseCategory";
                    command.CommandText = sql1;
                    OleDbDataReader reader = command.ExecuteReader();
                    Dictionary<int, string> myDictionary = new Dictionary<int, string>();
                    while (reader.Read())
                    {
                        myDictionary.Add(reader.GetInt32(0), reader.GetString(1));
                        com_expensetype.DataSource = new BindingSource(myDictionary, null);
                        com_expensetype.DisplayMember = "Value";
                        com_expensetype.ValueMember = "Key";
                    }
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
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    MessageBox.Show("Data saved");
                    connection.Close();
                }
                catch(OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
