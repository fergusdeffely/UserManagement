
namespace UserManagement
{
    partial class ViewUsersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUsersForm));
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.checkBoxAdministrator = new System.Windows.Forms.CheckBox();
            this.pictureBoxUserImage = new System.Windows.Forms.PictureBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelUsers = new System.Windows.Forms.Label();
            this.labelUserInfo = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelCurrentUserName = new System.Windows.Forms.Label();
            this.labelCurrentUserEmail = new System.Windows.Forms.Label();
            this.panelLoggedInUser = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.labelAdministrator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).BeginInit();
            this.panelLoggedInUser.SuspendLayout();
            this.panelUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 15;
            this.listBoxUsers.Location = new System.Drawing.Point(27, 65);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(182, 199);
            this.listBoxUsers.TabIndex = 0;
            this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(10, 53);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(46, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name :";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(10, 21);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 15);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email :";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPhone.ForeColor = System.Drawing.Color.White;
            this.labelPhone.Location = new System.Drawing.Point(10, 85);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(48, 15);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Phone :";
            // 
            // checkBoxAdministrator
            // 
            this.checkBoxAdministrator.AutoSize = true;
            this.checkBoxAdministrator.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAdministrator.Checked = true;
            this.checkBoxAdministrator.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdministrator.Enabled = false;
            this.checkBoxAdministrator.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAdministrator.ForeColor = System.Drawing.Color.White;
            this.checkBoxAdministrator.Location = new System.Drawing.Point(106, 154);
            this.checkBoxAdministrator.Name = "checkBoxAdministrator";
            this.checkBoxAdministrator.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAdministrator.TabIndex = 4;
            this.checkBoxAdministrator.UseVisualStyleBackColor = true;
            // 
            // pictureBoxUserImage
            // 
            this.pictureBoxUserImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUserImage.Image")));
            this.pictureBoxUserImage.Location = new System.Drawing.Point(327, 21);
            this.pictureBoxUserImage.Name = "pictureBoxUserImage";
            this.pictureBoxUserImage.Size = new System.Drawing.Size(131, 128);
            this.pictureBoxUserImage.TabIndex = 6;
            this.pictureBoxUserImage.TabStop = false;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGroup.ForeColor = System.Drawing.Color.White;
            this.labelGroup.Location = new System.Drawing.Point(10, 117);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(48, 15);
            this.labelGroup.TabIndex = 7;
            this.labelGroup.Text = "Group :";
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsers.ForeColor = System.Drawing.Color.White;
            this.labelUsers.Location = new System.Drawing.Point(27, 27);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(56, 20);
            this.labelUsers.TabIndex = 8;
            this.labelUsers.Text = "Users :";
            // 
            // labelUserInfo
            // 
            this.labelUserInfo.AutoSize = true;
            this.labelUserInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUserInfo.ForeColor = System.Drawing.Color.White;
            this.labelUserInfo.Location = new System.Drawing.Point(234, 27);
            this.labelUserInfo.Name = "labelUserInfo";
            this.labelUserInfo.Size = new System.Drawing.Size(138, 20);
            this.labelUserInfo.TabIndex = 9;
            this.labelUserInfo.Text = "User Information :";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(27, 295);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 30);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add...";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.DarkBlue;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.ForeColor = System.Drawing.Color.White;
            this.textBoxEmail.Location = new System.Drawing.Point(80, 21);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(218, 16);
            this.textBoxEmail.TabIndex = 11;
            this.textBoxEmail.Text = "andrea.rossi@groundworks.com";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.BackColor = System.Drawing.Color.DarkBlue;
            this.textBoxGroup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGroup.ForeColor = System.Drawing.Color.White;
            this.textBoxGroup.Location = new System.Drawing.Point(80, 117);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.ReadOnly = true;
            this.textBoxGroup.Size = new System.Drawing.Size(218, 16);
            this.textBoxGroup.TabIndex = 12;
            this.textBoxGroup.Text = "I.T.";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.Color.DarkBlue;
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhone.ForeColor = System.Drawing.Color.White;
            this.textBoxPhone.Location = new System.Drawing.Point(80, 85);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.ReadOnly = true;
            this.textBoxPhone.Size = new System.Drawing.Size(218, 16);
            this.textBoxPhone.TabIndex = 13;
            this.textBoxPhone.Text = "+353 89 2998773";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.DarkBlue;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.ForeColor = System.Drawing.Color.White;
            this.textBoxName.Location = new System.Drawing.Point(80, 53);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(218, 16);
            this.textBoxName.TabIndex = 14;
            this.textBoxName.Text = "Andrea Rossi";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(121, 295);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 30);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(20, 196);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(88, 30);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Edit...";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelCurrentUserName
            // 
            this.labelCurrentUserName.AutoSize = true;
            this.labelCurrentUserName.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentUserName.Location = new System.Drawing.Point(16, 12);
            this.labelCurrentUserName.Name = "labelCurrentUserName";
            this.labelCurrentUserName.Size = new System.Drawing.Size(98, 12);
            this.labelCurrentUserName.TabIndex = 0;
            this.labelCurrentUserName.Text = "Tom Walsh (Admin)";
            // 
            // labelCurrentUserEmail
            // 
            this.labelCurrentUserEmail.AutoSize = true;
            this.labelCurrentUserEmail.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentUserEmail.Location = new System.Drawing.Point(16, 30);
            this.labelCurrentUserEmail.Name = "labelCurrentUserEmail";
            this.labelCurrentUserEmail.Size = new System.Drawing.Size(148, 12);
            this.labelCurrentUserEmail.TabIndex = 1;
            this.labelCurrentUserEmail.Text = "tom.walsh@groundworks.com";
            // 
            // panelLoggedInUser
            // 
            this.panelLoggedInUser.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelLoggedInUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLoggedInUser.Controls.Add(this.buttonLogout);
            this.panelLoggedInUser.Controls.Add(this.labelCurrentUserEmail);
            this.panelLoggedInUser.Controls.Add(this.labelCurrentUserName);
            this.panelLoggedInUser.Location = new System.Drawing.Point(397, 343);
            this.panelLoggedInUser.Name = "panelLoggedInUser";
            this.panelLoggedInUser.Size = new System.Drawing.Size(308, 57);
            this.panelLoggedInUser.TabIndex = 18;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(208, 15);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(88, 30);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.BackColor = System.Drawing.Color.DarkBlue;
            this.panelUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUserInfo.Controls.Add(this.labelAdministrator);
            this.panelUserInfo.Controls.Add(this.buttonEdit);
            this.panelUserInfo.Controls.Add(this.textBoxName);
            this.panelUserInfo.Controls.Add(this.textBoxPhone);
            this.panelUserInfo.Controls.Add(this.textBoxGroup);
            this.panelUserInfo.Controls.Add(this.textBoxEmail);
            this.panelUserInfo.Controls.Add(this.pictureBoxUserImage);
            this.panelUserInfo.Controls.Add(this.labelGroup);
            this.panelUserInfo.Controls.Add(this.checkBoxAdministrator);
            this.panelUserInfo.Controls.Add(this.labelPhone);
            this.panelUserInfo.Controls.Add(this.labelEmail);
            this.panelUserInfo.Controls.Add(this.labelName);
            this.panelUserInfo.Location = new System.Drawing.Point(227, 65);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(478, 244);
            this.panelUserInfo.TabIndex = 19;
            // 
            // labelAdministrator
            // 
            this.labelAdministrator.AutoSize = true;
            this.labelAdministrator.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAdministrator.ForeColor = System.Drawing.Color.White;
            this.labelAdministrator.Location = new System.Drawing.Point(10, 152);
            this.labelAdministrator.Name = "labelAdministrator";
            this.labelAdministrator.Size = new System.Drawing.Size(90, 15);
            this.labelAdministrator.TabIndex = 17;
            this.labelAdministrator.Text = "Administrator :";
            // 
            // ViewUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(728, 437);
            this.Controls.Add(this.panelLoggedInUser);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelUserInfo);
            this.Controls.Add(this.labelUsers);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.panelUserInfo);
            this.Name = "ViewUsersForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.ViewUsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).EndInit();
            this.panelLoggedInUser.ResumeLayout(false);
            this.panelLoggedInUser.PerformLayout();
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.CheckBox checkBoxAdministrator;
        private System.Windows.Forms.PictureBox pictureBoxUserImage;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.Label labelUserInfo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelCurrentUserName;
        private System.Windows.Forms.Label labelCurrentUserEmail;
        private System.Windows.Forms.Panel panelLoggedInUser;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Label labelAdministrator;
    }
}