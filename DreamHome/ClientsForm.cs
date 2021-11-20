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
    public partial class ClientsForm : Form
    {
        DBConnection db;
        DataSet ds;
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void StaffGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void formclients_Load(object sender, EventArgs e)
        {
            db = new DBConnection();
            db.connectDB();

            ds = new DataSet();
            //DBConnection 
            //db.connectDB();
            //DataSet 
            ds = db.SelectDB("select * from Client", "Client");

            ClientNoTextBox.DataBindings.Add("Text", ds, "Client.Id");
            ClientFNameTextBox.DataBindings.Add("Text", ds, "Client.fname");
            ClientLNameTextBox.DataBindings.Add("Text", ds, "Client.lname");
            ClientMaxRentmaskedTextBox2.DataBindings.Add("Text", ds, "Client.maxrent");
            ClientPhoneNomaskedTextBox1.DataBindings.Add("Text", ds, "Client.phone");
            ClientEmailTextBox.DataBindings.Add("Text", ds, "Client.email");


            //RegistrationClientComboBox.Items.Insert(0, "Choose your Items");
            //RegistrationClientComboBox.DataSource = ds;
            //RegistrationClientComboBox.DisplayMember = "Client.lName";
            //RegistrationClientComboBox.ValueMember = "Client.Id";

            ds = db.SelectDB("select * from Branch", "Branch");
           
            RegistrationBranchComboBox.DataSource = ds;
            RegistrationBranchComboBox.DisplayMember = "Branch.city";
            RegistrationBranchComboBox.ValueMember = "Branch.Id";

            ds = db.SelectDB("select * from Staff", "Staff");

            RegistrationStaffComboBox.DataSource = ds;
            RegistrationStaffComboBox.DisplayMember = "Staff.fname";
            RegistrationStaffComboBox.ValueMember = "Staff.Id";
            
       //// string x=   Convert.ToString(RegistrationDateTimePicker.Value);
               
            
           // MessageBox.Show(x);

        }
        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(RegistrationClientComboBox.SelectedValue.ToString());
            //ds = db.SelectDB("select * from client where Client.id=" + RegistrationClientComboBox.SelectedValue, "client");
            ////ds = db.SelectDB("select * from Branch where Branch.id=" + RegistrationBranchComboBox.SelectedValue, "Branch");
            ////ds = db.SelectDB("select * from Staff where Staff.id=" + RegistrationStaffComboBox.SelectedValue, "Staff");


        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
             
       }

        private void buttonOwenr_Click(object sender, EventArgs e)
        {
            OwnersPropertiesForm B = new OwnersPropertiesForm();
            B.Show();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void buttonClient_Click_1(object sender, EventArgs e)
        {
            
        }

        private void buttonOwenrs_Click(object sender, EventArgs e)
        {
            OwnersPropertiesForm o = new OwnersPropertiesForm();
            o.Show();
            this.Hide();
        }

        private void buttonBranche_Click(object sender, EventArgs e)
        {
            StaffBranchForm b = new StaffBranchForm();
            b.Show();
            this.Hide();
        }

        private void StaffNoLabel_Click(object sender, EventArgs e)
        {

        }

        private void StaffPositionLabel_Click(object sender, EventArgs e)
        {

        }

        private void ClientsMenuUserControl_Load(object sender, EventArgs e)
        {

        }

        private void ClientNoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        public string GetSelectedRadioButtonText(RadioButton[] radioButtons)
        {
            // possible additional checks: check multiple selected, check if at least one is selected and generate more descriptive exception.

            // works for above cases, but throws a generic InvalidOperationException if it fails
            return radioButtons.Single(r => r.Checked).Text;
        }


        private void ClientSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string queryn = "insert into Client (fname,lname,phone,email,preftype,maxrent) values('" + ClientFNameTextBox.Text + "','" + ClientLNameTextBox.Text + "','" + ClientPhoneNomaskedTextBox1.Text + "','" + ClientEmailTextBox.Text + "','" + this.GetSelectedRadioButtonText(new[] { ClientFlatRadioButton, ClientHouseRadioButton, ClientNoneRadioButton }) + "'," + Convert.ToInt16(ClientMaxRentmaskedTextBox2.Text) + ") ";
                db.Insert_Update_deleteDB(queryn);
                MessageBox.Show("Your Data Saved");
            }
            catch (Exception Error)
            {

                MessageBox.Show(Error.Message);

            }
        }

        private void ClientAddButton_Click(object sender, EventArgs e)
        {
            //try
            //{
                BindingContext[ds, "client"].AddNew();
            //}
        
            //catch {
            //    MessageBox.Show(Error.Message); }
        }

        private void ClientModifyButton_Click(object sender, EventArgs e)
        {

            string query = "update Client set fname='" + ClientFNameTextBox.Text + "' where id=" + Convert.ToInt16(ClientNoTextBox.Text);
            db.Insert_Update_deleteDB(query);
            MessageBox.Show("Your Data Updated ");
        }

        private void ClientDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure You want to delete the recored", "Delet Categories", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                string query = "delete from Client where id=" + Convert.ToInt16(ClientNoTextBox.Text);
                db.Insert_Update_deleteDB(query);
                MessageBox.Show("Your Data Deleted ");
            }
            
        }

        private void RegistrationGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ClientNextButton_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Client"].Position += 1;

        }

        private void ClientPrevButton_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Client"].Position -= 1 ; 

        }

        private void RegistrationNextButton_Click(object sender, EventArgs e)
        {
           // this.BindingContext[ds, "Branch"].Position += 1;

        }

        private void RegistrationPrevButton_Click(object sender, EventArgs e)
        {
           // this.BindingContext[ds, "Branch"].Position += 1;

        }
    }
}
