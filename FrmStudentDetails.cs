﻿using System;
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
    public partial class FrmStudentDetails : MetroFramework.Forms.MetroForm
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["SchoolApp.Properties.Settings.Setting"].ConnectionString;
        private OleDbConnection connection = new OleDbConnection(connectionString);
        Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        public String Ad { get; set; }
        public String Ed { get; set; }
        string de;
      
        public FrmStudentDetails()
        {
            InitializeComponent();
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
                connection.Close();
                
                    
            }


            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void FrmStudentDetails_Load(object sender, EventArgs e)
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
        }

        public void load2()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            
          //  btn.HeaderText = "Print";
            btn.Text = "Print";
           // btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);

            DataGridViewButtonColumn btnn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btnn);
           // btnn.HeaderText = "Edit";
            btnn.Text = "Edit";
           // btnn.Name = "btn";
            btnn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btnnn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btnnn);
           // btnnn.HeaderText = "Delete";
            btnnn.Text = "Delete";
           // btnnn.Name = "btn";
            btnnn.UseColumnTextForButtonValue = true;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                StudentReport s = new StudentReport(this);
                Ad = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                s.ShowDialog();
            }

            if (e.ColumnIndex == 1)
            {
                EditStudent ed = new EditStudent(this);
                Ed = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                ed.ShowDialog();
            }

            if (e.ColumnIndex == 2)
            {
                de = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                delete();
            }
        }

        public void delete()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "delete from StudentDetails where AdmissionID = '" + de + "' ";
                if (MessageBox.Show("Do you want to delete?", "Remove row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    command.ExecuteNonQuery();
                connection.Close();
                // MessageBox.Show("Data deleted");
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }
    }
}
