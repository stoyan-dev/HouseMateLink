using System.Text.Json;

namespace HouseMateLink
{
    public partial class logIn : Form
    {
        private Building myBuilding;
        private bool isAdmin;
        public logIn()
        {
            InitializeComponent();
            Initialization();
            string filePath = "user.json";

            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                List<User> users = JsonSerializer.Deserialize<List<User>>(jsonString);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            List<User> users = LoadUsersFromJson("users.json");

            if (!ValidateUser(users))
            {
                MessageBox.Show("Incorrect username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MainForm mainForm = new MainForm(isAdmin);
                mainForm.Show();
                this.Hide();
            }
        }

        private bool ValidateUser(List<User> users)
        {
            foreach (User user in users)
            {
                if (user.Username == tbUsername.Text && user.Password == tbPassword.Text)
                {
                    isAdmin = user.Role == Role.ADMIN;
                    return true;
                }
            }
            return false;
        }

        private List<User> LoadUsersFromJson(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string jsonString = File.ReadAllText(filePath);
                    return JsonSerializer.Deserialize<List<User>>(jsonString);
                }
                else
                {
                    MessageBox.Show("User file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<User>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading user file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<User>();
            }
        }

        private void Initialization()
        {
            myBuilding = new Building("Student Housing B.V.");
            isAdmin = false;
        }
    }
}
