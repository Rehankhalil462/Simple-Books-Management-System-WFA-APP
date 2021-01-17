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
    public partial class DashboardForm : Form
    {
        FileInfo file;
        string date_time;
        StreamWriter writer;
        public DashboardForm()
        {
            InitializeComponent();
            //file = new FileInfo(@"your file path");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            date_time = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            writer = file.AppendText();
            writer.WriteLine("Logged out at " + date_time);
            writer.Close();
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewForm form1 = new ViewForm();
            form1.Show();
        }
    }
}
