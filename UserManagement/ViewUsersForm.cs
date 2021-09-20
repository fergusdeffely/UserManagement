﻿using System;
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
            // TODO: Find currently selected user
            //       Launch the AddEditUserForm in 'Add' mode (passing selected user as param)

            AddEditUserForm editUserForm = new AddEditUserForm();
            editUserForm.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            // TODO: Close this form
            //       Reset currentUser on LoginForm
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // TODO: Launch the AddEditUserForm in 'Add' mode
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // TODO: Find currently selected user
            //       Prompt to verify Delete
            //       if Yes: Delete from DB
        }        

        private void ViewUsersForm_Load(object sender, EventArgs e)
        {
            RefreshList();
            RefreshUserDetails(this.listBoxUsers.SelectedItem as User);

            // TODO: RefreshControls()
            // TODO: RefreshLoggedInUserDetails()
        }

        private void RefreshList()
        {
            // Get list of users
            UsersDB usersDB = new UsersDB();

            List<User> userList = usersDB.GetUsers(db);

            this.listBoxUsers.Items.Clear();
            this.listBoxUsers.Items.AddRange(userList.ToArray());
            
            int currentUserIndex = this.listBoxUsers.FindString(this.currentUser.ToString());

            this.listBoxUsers.SelectedIndex = currentUserIndex;
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

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            User selectedUser = this.listBoxUsers.SelectedItem as User;

            RefreshUserDetails(selectedUser);
            // TODO: RefreshControls()
        }
    }
}
