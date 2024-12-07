using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseMateLink
{
    public partial class ProfileOverviewAdmin : Form
    {
        private Building building;
        private User user;
        string selectedPhotoFilePathEdit = null;
        string selectedPhotoFilePathAdd = null;

        public ProfileOverviewAdmin()
        {
            InitializeComponent();
            building = new Building("");
            cbAddRole.DataSource = Role.GetValues(typeof(Role));
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedPhotoFilePathAdd = openFileDialog.FileName;
                    pbNewUser.Image = Image.FromFile(selectedPhotoFilePathAdd);
                    pbNewUser.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void btnEditPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedPhotoFilePathEdit = openFileDialog.FileName;
                    pbUser.Image = Image.FromFile(selectedPhotoFilePathEdit);
                    pbUser.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            string name = tbAddName.Text;
            Role role = (Role)cbAddRole.SelectedIndex;
            int roomNum = (int)nudAddRoom.Value;
            string username = tbAddUsername.Text;
            string password = tbAddPassword.Text;

            user = new User();
            building.AddUser();
        }
    }
}
