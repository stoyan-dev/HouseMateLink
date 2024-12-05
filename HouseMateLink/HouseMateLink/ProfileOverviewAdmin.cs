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

namespace HouseMateLink
{
    public partial class ProfileOverviewAdmin : Form
    {
        private Building building;
        private User user;
        public ProfileOverviewAdmin()
        {
            InitializeComponent();
            building = new Building();
            cbAddRole.DataSource = Role.GetValues(typeof(Role));
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Choose a Photo",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                try
                {
                    pbNewUser.Image = Image.FromFile(selectedFilePath);
                    pbNewUser.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Choose a Photo",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                try
                {
                    pbUser.Image = Image.FromFile(selectedFilePath);
                    pbUser.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string photoFile = pbNewUser.Text;

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(photoFile))
            {
                MessageBox.Show("All fields must be filled out, including selecting a photo.", "Validation Error");
                return;
            }

            User user = new User(username, password, name, role, roomNum, photoFile);
            building.AddUser(user);

            MessageBox.Show("New user added successfully.");
            tbAddName.Clear();
            nudAddRoom.Value = 0;
            tbAddUsername.Clear();
            tbAddPassword.Clear();
            pbNewUser.Image = null; 
        }
       
        }
    }
    

