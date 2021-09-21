
namespace UserManagement
{
    partial class AddEditUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditUserForm));
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.labelPassword2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.buttonBrowseImage = new System.Windows.Forms.Button();
            this.textBoxImageLocation = new System.Windows.Forms.TextBox();
            this.labelImage = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.pictureBoxUserImage = new System.Windows.Forms.PictureBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.checkBoxAdministrator = new System.Windows.Forms.CheckBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelUserInfo = new System.Windows.Forms.Label();
            this.panelUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.BackColor = System.Drawing.Color.DarkBlue;
            this.panelUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUserInfo.Controls.Add(this.textBoxPassword2);
            this.panelUserInfo.Controls.Add(this.labelPassword2);
            this.panelUserInfo.Controls.Add(this.textBoxPassword);
            this.panelUserInfo.Controls.Add(this.labelPassword);
            this.panelUserInfo.Controls.Add(this.comboBoxGroup);
            this.panelUserInfo.Controls.Add(this.buttonBrowseImage);
            this.panelUserInfo.Controls.Add(this.textBoxImageLocation);
            this.panelUserInfo.Controls.Add(this.labelImage);
            this.panelUserInfo.Controls.Add(this.textBoxName);
            this.panelUserInfo.Controls.Add(this.textBoxPhone);
            this.panelUserInfo.Controls.Add(this.textBoxEmail);
            this.panelUserInfo.Controls.Add(this.pictureBoxUserImage);
            this.panelUserInfo.Controls.Add(this.labelGroup);
            this.panelUserInfo.Controls.Add(this.checkBoxAdministrator);
            this.panelUserInfo.Controls.Add(this.labelPhone);
            this.panelUserInfo.Controls.Add(this.labelEmail);
            this.panelUserInfo.Controls.Add(this.labelName);
            this.panelUserInfo.Location = new System.Drawing.Point(38, 62);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(492, 320);
            this.panelUserInfo.TabIndex = 20;
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxPassword2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword2.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword2.Location = new System.Drawing.Point(80, 149);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.Size = new System.Drawing.Size(218, 23);
            this.textBoxPassword2.TabIndex = 22;
            this.textBoxPassword2.UseSystemPasswordChar = true;
            // 
            // labelPassword2
            // 
            this.labelPassword2.AutoSize = true;
            this.labelPassword2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassword2.ForeColor = System.Drawing.Color.White;
            this.labelPassword2.Location = new System.Drawing.Point(10, 151);
            this.labelPassword2.Name = "labelPassword2";
            this.labelPassword2.Size = new System.Drawing.Size(46, 15);
            this.labelPassword2.TabIndex = 21;
            this.labelPassword2.Text = "Verify :";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.Location = new System.Drawing.Point(80, 116);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(218, 23);
            this.textBoxPassword.TabIndex = 20;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(10, 118);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(65, 15);
            this.labelPassword.TabIndex = 19;
            this.labelPassword.Text = "Password :";
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboBoxGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Items.AddRange(new object[] {
            "Accounts",
            "Development",
            "I.T.",
            "Human Resources",
            "Marketing",
            "Operations",
            "Quality Assurance",
            "Sales"});
            this.comboBoxGroup.Location = new System.Drawing.Point(80, 183);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(218, 23);
            this.comboBoxGroup.TabIndex = 18;
            // 
            // buttonBrowseImage
            // 
            this.buttonBrowseImage.Location = new System.Drawing.Point(427, 249);
            this.buttonBrowseImage.Name = "buttonBrowseImage";
            this.buttonBrowseImage.Size = new System.Drawing.Size(31, 24);
            this.buttonBrowseImage.TabIndex = 17;
            this.buttonBrowseImage.Text = "...";
            this.buttonBrowseImage.UseVisualStyleBackColor = true;
            this.buttonBrowseImage.Click += new System.EventHandler(this.buttonBrowseImage_Click);
            // 
            // textBoxImageLocation
            // 
            this.textBoxImageLocation.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxImageLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxImageLocation.Enabled = false;
            this.textBoxImageLocation.ForeColor = System.Drawing.Color.Black;
            this.textBoxImageLocation.Location = new System.Drawing.Point(80, 250);
            this.textBoxImageLocation.Name = "textBoxImageLocation";
            this.textBoxImageLocation.Size = new System.Drawing.Size(340, 23);
            this.textBoxImageLocation.TabIndex = 16;
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelImage.ForeColor = System.Drawing.Color.White;
            this.labelImage.Location = new System.Drawing.Point(10, 252);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(48, 15);
            this.labelImage.TabIndex = 15;
            this.labelImage.Text = "Image :";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.ForeColor = System.Drawing.Color.Black;
            this.textBoxName.Location = new System.Drawing.Point(80, 51);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(218, 23);
            this.textBoxName.TabIndex = 14;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhone.ForeColor = System.Drawing.Color.Black;
            this.textBoxPhone.Location = new System.Drawing.Point(80, 83);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(218, 23);
            this.textBoxPhone.TabIndex = 13;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.ForeColor = System.Drawing.Color.Black;
            this.textBoxEmail.Location = new System.Drawing.Point(80, 19);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(218, 23);
            this.textBoxEmail.TabIndex = 11;
            // 
            // pictureBoxUserImage
            // 
            this.pictureBoxUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUserImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUserImage.Image")));
            this.pictureBoxUserImage.Location = new System.Drawing.Point(327, 19);
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
            this.labelGroup.Location = new System.Drawing.Point(10, 183);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(48, 15);
            this.labelGroup.TabIndex = 7;
            this.labelGroup.Text = "Group :";
            // 
            // checkBoxAdministrator
            // 
            this.checkBoxAdministrator.AutoSize = true;
            this.checkBoxAdministrator.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAdministrator.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAdministrator.ForeColor = System.Drawing.Color.White;
            this.checkBoxAdministrator.Location = new System.Drawing.Point(10, 218);
            this.checkBoxAdministrator.Name = "checkBoxAdministrator";
            this.checkBoxAdministrator.Size = new System.Drawing.Size(109, 19);
            this.checkBoxAdministrator.TabIndex = 4;
            this.checkBoxAdministrator.Text = "Administrator :";
            this.checkBoxAdministrator.UseVisualStyleBackColor = true;
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
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(38, 411);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(84, 35);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(146, 411);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 35);
            this.buttonCancel.TabIndex = 22;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelUserInfo
            // 
            this.labelUserInfo.AutoSize = true;
            this.labelUserInfo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUserInfo.ForeColor = System.Drawing.Color.White;
            this.labelUserInfo.Location = new System.Drawing.Point(38, 22);
            this.labelUserInfo.Name = "labelUserInfo";
            this.labelUserInfo.Size = new System.Drawing.Size(167, 25);
            this.labelUserInfo.TabIndex = 18;
            this.labelUserInfo.Text = "User Information :";
            // 
            // AddEditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(591, 473);
            this.Controls.Add(this.labelUserInfo);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panelUserInfo);
            this.Name = "AddEditUserForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.AddEditUserForm_Load);
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Button buttonBrowseImage;
        private System.Windows.Forms.TextBox textBoxImageLocation;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.PictureBox pictureBoxUserImage;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.CheckBox checkBoxAdministrator;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelUserInfo;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.TextBox textBoxPassword2;
        private System.Windows.Forms.Label labelPassword2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
    }
}