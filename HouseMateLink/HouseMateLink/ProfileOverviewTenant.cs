using System.Text.Json;

namespace HouseMateLink
{
    public partial class ProfileOverviewTenant : Form
    {
        private Building myBuilding;
        private DBHelper myDBHelper;
        private bool isAdmin;
        private User currentUser;
        public ProfileOverviewTenant(Building b, bool a, User user)
        {
            InitializeComponent();
            myBuilding = b;
            isAdmin = a;
            this.currentUser = user;
            myDBHelper = new DBHelper();
            //LoadUsersFromJson();
            PopulateUserSummariesPanel();
        }

        //private List<User> LoadUsersFromJson()
        //{
        //    string filePath = "users.json";
        //    if (!File.Exists(filePath))
        //    {
        //        return new List<User>();
        //    }

        //    try
        //    {
        //        string jsonString = File.ReadAllText(filePath);
        //        return JsonSerializer.Deserialize<List<User>>(jsonString) ?? new List<User>();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error reading user data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return new List<User>();
        //    }
        //}
              
        private void PopulateUserSummariesPanel()
        {
            UserInfoSummaryPanel.Controls.Clear();

            List<User> users = myDBHelper.LoadUsersFromDBForTenant();

            if (users != null && users.Count > 0)
            {
                int panelWidth = UserInfoSummaryPanel.Width;
                int controlWidth = 200;
                int controlHeight = 250;
                int padding = 10;

                int columns = panelWidth / (controlWidth + padding);
                if (columns < 1) columns = 1;

                int x = padding;
                int y = padding;

                for (int i = 0; i < users.Count; i++)
                {
                    User user = users[i];

                    Image userPhoto = null;
                    try
                    {
                        if (!string.IsNullOrWhiteSpace(user.Photo))
                        {
                            byte[] photoBytes = Convert.FromBase64String(user.Photo);

                            using (MemoryStream ms = new MemoryStream(photoBytes))
                            {
                                userPhoto = Image.FromStream(ms);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            $"Error loading photo for {user.Name}: {ex.Message}",
                            "Photo Load Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }

                    UserInfoSummaryControl summaryControl = new UserInfoSummaryControl(
                        user.Name,
                        user.Role,
                        user.RoomNumber,
                        userPhoto
                    )
                    {
                        Size = new Size(controlWidth, controlHeight),
                        Location = new Point(x, y)
                    };

                    UserInfoSummaryPanel.Controls.Add(summaryControl);

                    if ((i + 1) % columns == 0)
                    {
                        x = padding;
                        y += controlHeight + padding;
                    }
                    else
                    {
                        x += controlWidth + padding;
                    }
                }

                UserInfoSummaryPanel.AutoScrollMinSize = new Size(
                    UserInfoSummaryPanel.Width,
                    y + controlHeight + padding
                );
            }
            else
            {
                UserInfoSummaryPanel.AutoScrollMinSize = new Size(UserInfoSummaryPanel.Width, 0);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(isAdmin, this.currentUser, myBuilding);
            form.Show();
            this.Hide();
        }

        private void UserInfoSummaryPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
