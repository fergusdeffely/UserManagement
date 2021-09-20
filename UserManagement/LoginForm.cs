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

                bool foundEmail = false;
                bool passwordCorrect = false;

                User loggedInUser = null;

                // Check email address and password

                foreach(User user in userList)
                {
                    // Check email address exists

                    if (this.textBoxEmail.Text == user.Email)
                    {
                        foundEmail = true;

                        // Check password
                        if (this.textBoxPassword.Text == user.Password)
                        {
                            passwordCorrect = true;
                            loggedInUser = user;
                        }

                        break;
                    }
                }

                // foundEmail        passwordCorrect       case
                //     yes                yes                1. 
                //     yes                no                 2.
                //     no                 yes                3.
                //     no                 no                 3.

                // Case 1
                // If email and password are correct - log the user in.

                if (foundEmail == true && passwordCorrect == true)
                {
                    this.Visible = false;

                    ViewUsersForm viewUsersForm = new ViewUsersForm(db, loggedInUser);
                    viewUsersForm.ShowDialog();

                    this.Visible = true;
                }
                else if(foundEmail == true && passwordCorrect == false)
                {
                    // Case 2
                    MessageBox.Show("Incorrect password. Please try again.\n\n(Your password can be reset by contacting the I.T. department.)", "Password incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Case 3
                    MessageBox.Show($"The user: {this.textBoxEmail.Text} does not exist. Please try again.\n\n(If problems persist, please contact the I.T. department.)", "User not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                db.CloseConnection();
            }
        }
    }
}
