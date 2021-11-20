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
    public partial class LoginForm : Form

    {
        DBConnection db;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            db = new DBConnection();
            if (UsernameTextBox.Text != "" && PasswordTextBox.Text != "")
            {
                db.connectDB();
                DataSet ds = new DataSet();
                string query = "select * from [Users] where username='" + UsernameTextBox.Text + "' and password='" + PasswordTextBox.Text + "'";
                ds = db.SelectDB(query, "Users");

                if (ds.Tables["Users"].Rows.Count >= 1)
                {

                    ClientsForm f = new ClientsForm();
                    f.Show();
                    this.Hide();

                }
                else
                {
                    errorLabel.Text = "You entered a wrong usename or password!";
                }


            }
            else
            {
                errorLabel.Text = "You must enter a username or a password!";
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
