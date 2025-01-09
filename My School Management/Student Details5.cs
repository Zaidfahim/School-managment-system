using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace My_School_Management
{
    public partial class Student_Details5 : Form
    {
        SqlCoctnneion con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ASUS\documents\visual studio 2013\Projects\My School Management\My School Management\SchoolDB1.mdf;Integrated Security=True");
        SqlCommand com;
        public Student_Details5()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            school_Main_frm3 f3 = new school_Main_frm3();
            this.Hide();
            f3.Show();
        }

        private void Student_Details5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDB1DataSet.student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.schoolDB1DataSet.student);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            try
            {
                string Gender;
                if(radioButton1.Checked)
                {
                    Gender = "Male";
                }
                else
                {
                    Gender = "Female";
                }



               

            con.Open();
            string query = "insert into student ( Admission_No, First_Name, Surname, Date_Of_Birth, Address, Gender, Parent_Name, Parent_Contact_No) values ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "','" + Gender + "', '" + textBox6.Text + "', '" + textBox7.Text + "')";
            com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data added");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            con.Close();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            try
            {
                con.Open();
                string query2 = "Select * from student where Admission_No = '" + textBox1.Text + "'";

            com = new SqlCommand(query2, con);
            SqlDataReader SQLdr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(SQLdr);
;
            dataGridView1.DataSource = dt;
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
                
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string gender;
            try
            {  if(radioButton1.Checked) { gender = "Male"; }
                if (radioButton2.Checked) { gender = "Female"; }
               

            con.Open();
            string query = "update into student Values ('" + textBox1 + "','" + textBox2 + "','" + textBox3 + "', '" + textBox4 + "','" + textBox5 + "', '" + textBox6 + "', '" + textBox7 + "'";
            com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated!");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

            }
            catch (Exception ex)
            {
                
              
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string gender;
            try
            { if(radioButton1.Checked) { gender = "Male"; }
                if (radioButton2.Checked) { gender = "Female"; }


                con.Open();
                string query = "Delete from student Where ID = '" + textBox1.Text + "'";
                com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Deleted");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();


            }
            catch (Exception ex)
            {
                
               
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
