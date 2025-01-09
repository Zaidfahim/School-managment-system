using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_School_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
         
                Thread t = new Thread(new ThreadStart(startform));
                t.Start();
                Thread.Sleep(5000);


        


            InitializeComponent();
            t.Abort();
         }
        public void startform()
        {
            Application.Run(new welcome_screen());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = "Akmal";
            string Password = "1989";

            if (Username == textBox1.Text && Password == textBox2.Text)
            {
                school_Main_frm3 f3 = new school_Main_frm3();
                this.Hide();
                f3.Show();
            }
            else
            {
                MessageBox.Show("Username or Password incorrect");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
