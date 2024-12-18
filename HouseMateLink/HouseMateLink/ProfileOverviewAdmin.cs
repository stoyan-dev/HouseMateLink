using System.Text.Json;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;

namespace HouseMateLink
{
    public partial class ProfileOverviewAdmin : Form
    {
        private Building building;
        private DBHelper myDBHelper;
        private User currentUser;
        private string selectedPhotoFilePathEdit = null;
        private string selectedPhotoFilePathAdd = null;
        private bool isAdmin;
        private string connStr = "Server=mssqlstud.fhict.local;Database=dbi550238;User Id=dbi550238;Password=12345;TrustServerCertificate=True";

        public ProfileOverviewAdmin(bool a, User user)
        {
            InitializeComponent();
            building = new Building("", 6);
            cbAddRole.DataSource = Role.GetValues(typeof(Role));
            isAdmin = a;
            myDBHelper = new DBHelper();
            cbRoom.Items.Clear();
            currentUser = user;
            ManageAvailableRooms(6);
            UserInfoPanel.AutoScroll = true;
            PopulateUserInfoPanel();
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

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            string name = tbAddName.Text;
            Role role = (Role)cbAddRole.SelectedItem;
            int roomNum = (int)cbRoom.SelectedItem;
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

            User user = new User(username, password, name, role, roomNum, photoFile);
            myDBHelper.AddUser(user);

            if (user.Role == Role.ADMIN)
            {
                user.RoomNumber = 0;
            }

            MessageBox.Show("New user added successfully!");

            tbAddName.Clear();
            cbRoom.Text = cbRoom.Items[0].ToString();
            tbAddUsername.Clear();
            tbAddPassword.Clear();
            pbNewUser.Image = null;
            selectedPhotoFilePathAdd = null;

            PopulateUserInfoPanel();
        }

        private void PopulateUserInfoPanel()
        {
            UserInfoPanel.Controls.Clear();
            List<User> users = myDBHelper.LoadUsersFromDBForAdmin();
            int yPosition = 0;

            foreach (User newUser in users)
            {
                if (newUser != null)
                {
                    Image userPhoto = null;
                    try
                    {
                        userPhoto = Image.FromFile(newUser.Photo);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Failed to load photo for {newUser.Name}. Error: {ex.Message}");
                        //userPhoto = Properties.Resources.DefaultUserPhoto;
                    }

                    UserInfoControl userInfoControl = new UserInfoControl(
                        newUser.Name,
                        newUser.Role.ToString(),
                        newUser.RoomNumber.ToString(),
                        newUser.Username,
                        newUser.Password,
                        userPhoto,
                        userInfoControl => RemoveUser(userInfoControl, newUser)
                    );

                    userInfoControl.Size = new Size(400, 150);
                    userInfoControl.Location = new Point(10, yPosition);
                    yPosition += userInfoControl.Height + 10;

                    UserInfoPanel.Controls.Add(userInfoControl);
                }
            }

            UserInfoPanel.AutoScrollMinSize = new Size(UserInfoPanel.Width, yPosition);
        }

        private void RemoveUser(UserInfoControl userInfoControl, User user)
        {
            UserInfoPanel.Controls.Remove(userInfoControl);
            myDBHelper.RemoveUserFromDB(user);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm from = new MainForm(isAdmin, currentUser, building);
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
                    string queryUserRoom = @"SELECT RoomNumber FROM [USER]";

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

        private void UserInfoPanel_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
