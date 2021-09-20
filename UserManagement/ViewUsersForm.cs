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

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void ViewUsersForm_Load(object sender, EventArgs e)
        {
            RefreshList();
            RefreshUserDetails(this.listBoxUsers.SelectedItem as User);
        }

        private void RefreshList()
        {
            // Get list of users
            UsersDB usersDB = new UsersDB();

            List<User> userList = usersDB.GetUsers(db);

            this.listBoxUsers.Items.Clear();
            this.listBoxUsers.Items.AddRange(userList.ToArray());
            this.listBoxUsers.SelectedIndex = 1;
        }

        // Populate the User Details fields given a User object.

        private void RefreshUserDetails(User user)
        {
            // Update fields on form with data from user
            this.textBoxEmail.Text = user.Email;
            this.textBoxName.Text = user.Name;
            this.textBoxPhone.Text = user.Phone;
            this.textBoxGroup.Text = user.Group;
            this.checkBoxAdministrator.Checked = user.IsAdmin;
        }
    }
}
