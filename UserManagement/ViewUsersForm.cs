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

        private void ViewUsersForm_Load(object sender, EventArgs e)
        {
            RefreshList();

            // Select the currently logged in user
            this.listBoxUsers.SelectedIndex = IndexOfUser(this.currentUser);

            RefreshUserDetails(this.listBoxUsers.SelectedItem as User);
            RefreshControls(this.listBoxUsers.SelectedItem as User);
            RefreshLoggedInUserDetails();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            User user = this.listBoxUsers.SelectedItem as User;

            AddEditUserForm editUserForm = new AddEditUserForm(this.db, user, "edit");
            editUserForm.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddEditUserForm editUserForm = new AddEditUserForm(this.db, "add");
            editUserForm.ShowDialog();

            RefreshList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //int index = this.listBoxUsers.SelectedIndex;

            User user = this.listBoxUsers.SelectedItem as User;

            DialogResult result = MessageBox.Show($"You are about to delete the user:\n\n{user.Name}\n{user.Email}\n\nAre you sure?",
                                                   "Email address exists",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                UsersDB usersDB = new UsersDB();
                usersDB.Delete(this.db, user.Email);

                RefreshList();

                if(this.listBoxUsers.Items.Count > 0)
                {
                    this.listBoxUsers.SelectedIndex = 0;
                }
            }
        }

        private int IndexOfUser(User user)
        {
            bool emailMatches = false;
            int index = this.listBoxUsers.FindString(user.Name);

            while(emailMatches == false)
            {
                if(index >= 0)
                {
                    User candidate = this.listBoxUsers.Items[index] as User;
                    if(user.Email == candidate.Email)
                    {
                        emailMatches = true;
                    }
                    else
                    {
                        index = this.listBoxUsers.FindString(user.Name, index);
                    }
                }
                else
                {
                    return -1;
                }
            }

            return index;

        }

        private void RefreshList()
        {
            // Get list of users
            UsersDB usersDB = new UsersDB();

            List<User> userList = usersDB.GetUsers(db);

            this.listBoxUsers.Items.Clear();
            this.listBoxUsers.Items.AddRange(userList.ToArray());
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

        private void RefreshControls(User selectedUser)
        {
            if (this.currentUser.IsAdmin)
            {
                this.buttonAdd.Enabled = true;
                this.buttonDelete.Enabled = true;
                this.buttonEdit.Enabled = true;
            }
            else
            {
                this.buttonAdd.Enabled = false;
                this.buttonDelete.Enabled = false;
                this.buttonEdit.Enabled = false;
            }

            // User can always edit their own details, but not delete their own profile

            if (selectedUser.Email == this.currentUser.Email)
            {
                this.buttonEdit.Enabled = true;
                this.buttonDelete.Enabled = false;
            }
        }

        private void RefreshLoggedInUserDetails()
        {
            string admin = String.Empty;
            if(this.currentUser.IsAdmin)
            {
                admin = " (Admin)";
            }

            this.labelCurrentUserName.Text = $"{this.currentUser.Name}{admin}";
            this.labelCurrentUserEmail.Text = this.currentUser.Email;
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            User selectedUser = this.listBoxUsers.SelectedItem as User;

            RefreshUserDetails(selectedUser);
            RefreshControls(selectedUser);
        }
    }
}
