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
    
    public partial class Form1 : Form
    {
        DataAccess dataAccess;
        FileInfo file;
        string date_time;
        StreamWriter writer;

        public Form1()
        {
            InitializeComponent();

            dataAccess = new DataAccess();
            //file = new FileInfo(@"your file path");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int check;

            if (StudentNameTextBox.Text== string.Empty && DepartmentComboBox.SelectedIndex<0 && RollNoTextBox.Text == string.Empty && CategoryComboBox.SelectedIndex<0 && BookNameTextBox.Text==string.Empty )
            {
                MessageBox.Show("Fill all Fields!");
            }
            else if (StudentNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please enter student name");

            }
            else if(DepartmentComboBox.SelectedIndex<0)
            {
                MessageBox.Show("Please Select Department");

            }
            else if (RollNoTextBox.Text==string.Empty)
            {
                MessageBox.Show("Please Enter Roll Number");
            }
            else if(!int.TryParse(RollNoTextBox.Text, out check))
            {
                MessageBox.Show("Roll No can only be Integar");
                RollNoTextBox.Clear();
            }
            else if (CategoryComboBox.SelectedIndex<0)
            {
                MessageBox.Show("Please Select Category");

            }
            else if(BookNameTextBox.Text==string.Empty)
            {
                MessageBox.Show("please enter book name");
            }
            else
            {

            
            string Student_Name = StudentNameTextBox.Text;
            string Department = DepartmentComboBox.SelectedItem.ToString();
            string Roll_No = RollNoTextBox.Text;
            string Category = CategoryComboBox.SelectedItem.ToString();
            string Book_Name = BookNameTextBox.Text;
            DateTime Issuance_Date = IssuanceDateDateTimePicker.Value;
            DateTime Due_Date = DueDateDateTimePicker.Value;
            int recieved = dataAccess.InsertIntoBookIssuanceTable(Student_Name, Department, Roll_No, Category, Book_Name, Issuance_Date, Due_Date);
            if(recieved==1)
            {
                date_time = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
                writer = file.AppendText();
                writer.WriteLine("New Book is Issued at " + date_time);
                writer.Close();
                MessageBox.Show("Data is stored successfully");

            }
            else
            {
                MessageBox.Show("Data is not Stored Successfully");
            }
            StudentNameTextBox.Clear();
            DepartmentComboBox.SelectedIndex = -1;
            RollNoTextBox.Clear();
            CategoryComboBox.SelectedIndex = -1;
            BookNameTextBox.Clear();
            IssuanceDateDateTimePicker.ResetText();
            DueDateDateTimePicker.ResetText();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
        }
    }
}
