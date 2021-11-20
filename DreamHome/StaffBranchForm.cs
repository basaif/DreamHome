using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamHome
{
    public partial class StaffBranchForm : Form
    {
          DBConnection db;
        DataSet ds;


        public StaffBranchForm()
        {
            InitializeComponent();
        }

        private void BranchNextButton_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StaffBranchForm B = new StaffBranchForm();
            B.Show();
            this.Visible = false;
        }

        private void FormBranchSt_Load(object sender, EventArgs e)
        {
            db = new DBConnection();
            db.connectDB();
            ds = new DataSet();
         ds = db.SelectDB("select * from staff", "Staff");

            StaffNoTextBox.DataBindings.Add("Text", ds, "Staff.Id");
            StaffFNameTextBox.DataBindings.Add("Text", ds, "Staff.fname");
            StaffLNameTextBox.DataBindings.Add("Text", ds, "Staff.lname");
            //StaffPositionTextBox.DataBindings.Add("Text", ds, "Staff.position");
            StaffSalaryTextBox.DataBindings.Add("Text", ds, "Staff.salary");

            DataSet branchds = new DataSet();
            branchds = db.SelectDB("select * from branch", "Branch");

            BranchNoTextBox.DataBindings.Add("Text", branchds, "Branch.Id");
            BranchPostcodeTextBox.DataBindings.Add("Text", branchds, "Branch.postcode");
            BranchStreetTextBox.DataBindings.Add("Text", branchds, "Branch.street");
            BranchCityTextBox.DataBindings.Add("Text", branchds, "Branch.city");

            
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            ClientsForm C = new ClientsForm();
            this.Close();
            C.Show();
        }

        private void buttonOwenrs_Click(object sender, EventArgs e)
        {
            OwnersPropertiesForm O = new OwnersPropertiesForm();
            
            this.Hide();
            O.Show();
        }

        private void StaffNextButton_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Staff"].Position += 1;

        }

        private void StaffPrevButton_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Staff"].Position -= 1; 

        }
    }
}
