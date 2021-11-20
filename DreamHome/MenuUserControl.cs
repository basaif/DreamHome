using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamHome
{
    public partial class MenuUserControl : UserControl
    {
        public MenuUserControl()
        {
            InitializeComponent();
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            ClientsForm clients = new ClientsForm();
            clients.Show();
            ((Form)this.TopLevelControl).Close();
        }

        private void PropertiesOwnersButton_Click(object sender, EventArgs e)
        {
            OwnersPropertiesForm frm = new OwnersPropertiesForm();
            frm.Show();
            ((Form)this.TopLevelControl).Close();
        }

        private void StaffBranchesButton_Click(object sender, EventArgs e)
        {
            StaffBranchForm frm = new StaffBranchForm();
            frm.Show();
            ((Form)this.TopLevelControl).Close();
        }

        private void AvailablePropertiesButton_Click(object sender, EventArgs e)
        {
            SearchPropertiesForm frm = new SearchPropertiesForm();
            frm.Show();
            ((Form)this.TopLevelControl).Close();
        }

       
    }
}
