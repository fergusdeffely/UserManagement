using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagement
{
    public partial class AddEditUserForm : Form
    {
        public AddEditUserForm()
        {
            InitializeComponent();

            this.comboBoxGroup.SelectedItem = "Sales";
        }

        // TODO: Add Form_Load event handler
        //       if(mode == Add)
        //          set default control settings (dropdown, admin status, default image, etc)
        //       if(mode == Edit)
        //          update form for current user

        private void buttonSave_Click(object sender, EventArgs e)
        {

            // TODO:
            
            // Validation - check formats for email, phone and password

            // if(mode == Add)
            //     Insert new record in DB
            // if(mode == Edit)
            //     Update record in DB
        }

        private User CreateNewUser()
        {
            // Take the current information from the form fields and create and return a User object
        }

        private void buttonBrowseImage_Click(object sender, EventArgs e)
        {
            // Select new ImageFile using OpenFileDialog
            // Update PictureBox to display new Image

            /*
            string picturesPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            OpenFileDialog browseImageFileDialog = new OpenFileDialog();

            browseImageFileDialog.Title = "Select Image File";
            browseImageFileDialog.InitialDirectory = picturesPath;
            browseImageFileDialog.Filter = "Image files (*.png, *.gif, *.jpg, *.bmp)|*.png;*.gif;*.jpg;*.bmp";

            browseImageFileDialog.ShowDialog();

            string pictureFilename = browseImageFileDialog.FileName;
            Image userImage = Image.FromFile(pictureFilename);
            this.pictureBoxUserImage.Image = userImage;

            // If user image is larger than PictureBox, then Zoom out,
            // otherwise, center the image in the frame
            if(userImage.Width > pictureBoxUserImage.ClientSize.Width || 
               userImage.Height > pictureBoxUserImage.ClientSize.Height)
            {
                this.pictureBoxUserImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                this.pictureBoxUserImage.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            */
        }
    }
}
