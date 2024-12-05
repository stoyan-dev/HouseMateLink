using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json;

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
            string photoFile = selectedPhotoFilePathAdd;


            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(photoFile))
            {
                MessageBox.Show("All fields must be filled out, including selecting a photo.", "Validation Error");
                return;
            }


            building.CreateAddNewUser(username, password, name, role, roomNum, photoFile);

            MessageBox.Show("New user added successfully!");


            tbAddName.Clear();
            nudAddRoom.Value = 0;
            tbAddUsername.Clear();
            tbAddPassword.Clear();
            pbNewUser.Image = null;
            selectedPhotoFilePathAdd = null;

            List<User> users = building.GetTenants();
            string jsonString = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            try
            {
                File.WriteAllText("user.json", jsonString);
                MessageBox.Show("File created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to file: {ex.Message}");
            }

        }

    }
}
    

