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

            //List<User> users = LoadUsersFromJson();
            List<User> users = myDBHelper.LoadUsersFromDBForTenant();

            int x = 10, y = 10;
            if (users != null)
            {
                foreach (User user in users)
                {
                    Image userPhoto = null;
                    try
                    {
                        if (!string.IsNullOrWhiteSpace(user.Photo) && File.Exists(user.Photo))
                        {
                            userPhoto = Image.FromFile(user.Photo);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading photo for {user.Name}: {ex.Message}", "Photo Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    UserInfoSummaryControl summaryControl = new UserInfoSummaryControl(user.Name, user.Role, user.RoomNumber, userPhoto)
                    {
                        Size = new Size(200, 250),
                        Location = new Point(x, y)
                    };

                    y += summaryControl.Height + 10;

                    UserInfoSummaryPanel.Controls.Add(summaryControl);
                }

                UserInfoSummaryPanel.AutoScrollMinSize = new Size(UserInfoSummaryPanel.Width, y); ;

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
