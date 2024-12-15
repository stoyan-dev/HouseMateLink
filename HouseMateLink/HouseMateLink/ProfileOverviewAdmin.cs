﻿using System.Text.Json;
using Microsoft.Data.SqlClient;

namespace HouseMateLink
{
    public partial class ProfileOverviewAdmin : Form
    {
        private Building building;
        private User user;
        private string selectedPhotoFilePathEdit = null;
        private string selectedPhotoFilePathAdd = null;
        private bool isAdmin;
        private string connStr = "Server=mssqlstud.fhict.local;Database=dbi550238;User Id=dbi550238;Password=12345;";


        public ProfileOverviewAdmin(bool a)
        {
            InitializeComponent();
            building = new Building("",6);
            cbAddRole.DataSource = Role.GetValues(typeof(Role));
            isAdmin = a;
            ManageAvailableRooms(6);
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

        //private void btnEditPhoto_Click(object sender, EventArgs e)
        //{
        //    using (OpenFileDialog openFileDialog = new OpenFileDialog())
        //    {
        //        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
        //        if (openFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            selectedPhotoFilePathEdit = openFileDialog.FileName;
        //            pbUser.Image = Image.FromFile(selectedPhotoFilePathEdit);
        //            pbUser.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }
        //    }
        //}

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            string name = tbAddName.Text;
            Role role = (Role)cbAddRole.SelectedItem;
            int roomNum = (int)cbRoom.SelectedIndex;
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
            cbRoom.Text = cbRoom.Items[0].ToString();
            tbAddUsername.Clear();
            tbAddPassword.Clear();
            pbNewUser.Image = null;
            selectedPhotoFilePathAdd = null;

            List<User> users = building.GetUsers();
            string jsonString = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });

            try
            {
                File.WriteAllText("users.json", jsonString);
                MessageBox.Show("File created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to file: {ex.Message}");
            }

            User newUser = building.GetUsers().LastOrDefault(user => user.Username == username);

            if (newUser != null)
            {
                Image userPhoto = Image.FromFile(newUser.Photo);

                UserInfoControl userInfoControl = new UserInfoControl(newUser.Name, newUser.Role.ToString(), newUser.RoomNumber.ToString(), newUser.Username, newUser.Password, userPhoto, RemoveUser);

                userInfoControl.Size = new Size(400, 150);
                userInfoControl.Location = new Point(10, 10 + (UserInfoPanel.Controls.Count * 160));
                UserInfoPanel.Controls.Add(userInfoControl);
            }
        }

        private void RemoveUser(UserInfoControl userInfoControl)
        {
            UserInfoPanel.Controls.Remove(userInfoControl);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm from = new MainForm(isAdmin);
            from.Show();
            this.Hide();
        }

        private void cbAddRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAddRole.SelectedIndex == 0)
            {
                label3.Visible = true;
                cbRoom.Visible = true;
            }
            else
            {
                label3.Visible = false;
                cbRoom.Visible = false;
            }
        }

        private void ManageAvailableRooms(int amountOfRooms)
        {

            List<int> allRooms = new List<int>();
            for (int i = 1; i <= amountOfRooms; i++)
            {
                allRooms.Add(i); 
            }

            List<int> takenRooms = new List<int>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string queryUserRoom = @"SELECT RoomNumber FROM User";

                    using (SqlCommand cmd = new SqlCommand(queryUserRoom, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int roomNumber = reader.GetInt32(0);
                                takenRooms.Add(roomNumber);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            List<int> availableRooms = new List<int>();

         
            foreach (int room in allRooms)
            {
                if (!takenRooms.Contains(room))
                { 
                    availableRooms.Add(room);
                }
            }

            cbRoom.DataSource = availableRooms;
        }



    }
}


