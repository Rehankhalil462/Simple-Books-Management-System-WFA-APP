using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Library_Management_System
{
    public partial class LoginForm : Form
    {
        
        LoginClass loginClass;
        FileInfo file;
        string date_time;
        StreamWriter writer;

        public LoginForm()
        {
            InitializeComponent();
            
            loginClass = new LoginClass();
            //file = new FileInfo(@"your file path");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            if (username==loginClass.getusername())
            {
                if (password==loginClass.getpassword())
                {
                    date_time = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
                    writer = file.AppendText();
                    writer.WriteLine("Logged in at " + date_time);
                    writer.Close();
                    MessageBox.Show("Logged in Successfully");
                    this.Hide();
                    DashboardForm dashboardForm = new DashboardForm();
                    dashboardForm.Show();
                }
                else
                {
                    date_time = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
                    writer = file.AppendText();
                    writer.WriteLine("Invalid Password Attempt is made on " + date_time);
                    writer.Close();
                    MessageBox.Show("Invalid Password");
                    PasswordTextBox.Clear();
                }
               
            }
            else
            {
                date_time = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
                writer = file.AppendText();
                writer.WriteLine("Invalid Username Attempt is made on " + date_time);
                writer.Close();
                MessageBox.Show("Invalid username");
                UsernameTextBox.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
                PasswordTextBox.UseSystemPasswordChar = true;
        }
    }
}
