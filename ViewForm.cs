using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class ViewForm : Form
    {
        DataAccess dataAccess;
        List<IssuanceClass> issuanceClasses;
        public ViewForm()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
            issuanceClasses = dataAccess.GetAllData();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = issuanceClasses;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();

        }
    }
}
