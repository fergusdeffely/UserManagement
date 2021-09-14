using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UserManagementDB;

namespace UserManagement
{
    public partial class ViewUsersForm : Form
    {
        User currentUser = null;
        DBConnection db = null;

        public ViewUsersForm(DBConnection db, User currentUser)
        {
            InitializeComponent();

            this.currentUser = currentUser;
            this.db = db;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            AddEditUserForm editUserForm = new AddEditUserForm();
            editUserForm.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.currentUser.DescriptionString());
        }
    }
}
