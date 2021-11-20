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
    public partial class SearchPropertiesForm : Form
    {       
            DBConnection db;
            DataSet ds;

        public SearchPropertiesForm()
        {
            InitializeComponent();
        }

        private void AvailablePropertiesForm_Load(object sender, EventArgs e)
        {
            db = new DBConnection();
            db.connectDB();
            ds = new DataSet();
            ds = db.SelectDB("select Id , concat(fname, ' ', lname) as fullname from Client", "Client");


        }

        private void ClientComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //DataSet clientID = (DataSet)ClientComboBox.SelectedItem;
            DataSet pds = new DataSet();
            //test.Text = clientID.ToString();
            pds = db.SelectDB("select Id, street, city, postcode, type, rooms, rent from property", "AvailableProperties");

            PropertiesDataGridView.DataSource = pds;
            PropertiesDataGridView.DataMember = "AvailableProperties";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            string type;
            string rent;
            if ((houseRadioButton.Checked || flatRadioButton.Checked) && (rentTextBox.Text != ""))
            {
                decimal number3 = 0;
                rent = rentTextBox.Text;
                bool canConvert = decimal.TryParse(rent, out number3);
                if (canConvert)
                {
                  if (houseRadioButton.Checked)
                                {
                                    type = "House";
                                }
                                else
                                {
                                    type = "Flat";
                                }
                                DataSet pds = new DataSet();
                                pds = db.SelectDB("select Id, street, city, postcode, type, rooms, rent from property where type = '" + type + "' and rent < " + rent, "Properties");

                                PropertiesDataGridView.DataSource = pds;
                                PropertiesDataGridView.DataMember = "Properties";
                }

                else
                    errorLabel.Text = "Rent must be a number!";

                
              

            }
            else
            {
                errorLabel.Text = "All fields must have a value!";
            }
        }
    }
}
