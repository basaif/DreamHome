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
    public partial class OwnersPropertiesForm : Form
    {

        DBConnection db;
        DataSet ds;
        public OwnersPropertiesForm()
        {
            InitializeComponent();
        }

       

        private void StaffSalaryLabel_Click(object sender, EventArgs e)
        {

        }

        private void PropertyBranchNoLabel_Click(object sender, EventArgs e)
        {

        }

        private void OwnersPropertiesForm_Load(object sender, EventArgs e)
        {
            db = new DBConnection();
            db.connectDB();
            ds = new DataSet();
            ds = db.SelectDB("select * from PrivateOwner", "PrivateOwner");

            OwnerNoTextBox.DataBindings.Add("Text", ds, "PrivateOwner.Id");
            OwnerFNameTextBox.DataBindings.Add("Text", ds, "PrivateOwner.fname");
            OwnerLNameTextBox.DataBindings.Add("Text", ds, "PrivateOwner.lname");
            OwnerAddressTextBox.DataBindings.Add("Text", ds, "PrivateOwner.address");
            OwnerPhoneNoTextBox.DataBindings.Add("Text", ds, "PrivateOwner.phone");
            OwnerEmailTextBox.DataBindings.Add("Text", ds, "PrivateOwner.email");


            
            //ds = db.SelectDB("select * from property", "Property");

            //PropertyNoTextBox.DataBindings.Add("Text", ds, "Property.Id");
            //PropertyStreetTextBox.DataBindings.Add("Text", ds, "Property.street");
            //PropertyPostcodeTextBox.DataBindings.Add("Text", ds, "Property.postcode");
            //PropertyRoomsTextBox.DataBindings.Add("Text", ds, "Property.Rooms");
            //PropertyRentTextBox.DataBindings.Add("Text", ds, "Property.Rent");


        }

        private void OwnerPrevButton_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "PrivateOwner"].Position -= 1; 
        }

        private void OwnerNextButton_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "PrivateOwner"].Position += 1;
        }

        private void OwnerAddButton_Click(object sender, EventArgs e)
        {
            BindingContext[ds, "PrivateOwner"].AddNew();
        }

        private void OwnerDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the record?", "Delete Owner", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                string query = "delete from PrivateOwner where id=" + Convert.ToInt16(OwnerNoTextBox.Text);
                db.Insert_Update_deleteDB(query);
                MessageBox.Show("The record has been deleted.");
                
            }
        }

        private void OwnerModifyButton_Click(object sender, EventArgs e)
        {
            string query = "update PrivateOwner set fname='" + OwnerFNameTextBox.Text + "',lname='" + OwnerLNameTextBox.Text + "', address='" + OwnerAddressTextBox.Text + "', email='" + OwnerEmailTextBox.Text + "', phone='" + OwnerPhoneNoTextBox.Text + "' where id=" + Convert.ToInt16(OwnerNoTextBox.Text);
            db.Insert_Update_deleteDB(query);
            MessageBox.Show("The record has been modified.");
            
        }

        private void OwnerSaveButton_Click(object sender, EventArgs e)
        {
            string query = "insert into PrivateOwner (fname, lname, address, email, phone) values('" + OwnerFNameTextBox.Text + "', '" + OwnerLNameTextBox.Text + "', '" + OwnerAddressTextBox.Text + "', '" + OwnerEmailTextBox.Text + "', '" + OwnerPhoneNoTextBox.Text + "')";
            db.Insert_Update_deleteDB(query);
            MessageBox.Show("The record has been saved.");
           
        }


    }
}
