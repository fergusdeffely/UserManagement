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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Create database connection
            DBConnection db = new DBConnection("localhost", "usermanagement", "csharp", "password");

            if (db.OpenConnection())
            {
                // Get list of users
                UsersDB usersDB = new UsersDB();

                List<User> userList = usersDB.GetUsers(db);

                bool validCredentials = false;
                bool userFound = false;

                // Check email address and password

                foreach(User user in userList)
                {
                    // Check email address exists

                    if (this.textBoxEmail.Text == user.Email)
                    {
                        userFound = true;

                        // Check password
                        if (this.textBoxPassword.Text == user.Password)
                        {
                            validCredentials = true;
                        }
                        else
                        {
                            MessageBox.Show("Incorrect password. Please try again.\n\n(Your password can be reset by contacting the I.T. department.)", "Password incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        break;
                    }
                }

                // Warn user if email is not found

                if (userFound == false)
                {
                    MessageBox.Show($"The user: {this.textBoxEmail.Text} does not exist. Please try again.\n\n(If problems persist, please contact the I.T. department.)", "User not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Launch ViewUsersForm

                if(validCredentials)
                {
                    this.Visible = false;

                    ViewUsersForm viewUsersForm = new ViewUsersForm();
                    viewUsersForm.ShowDialog();

                    this.Visible = true;
                }
            }
        }
    }
}
