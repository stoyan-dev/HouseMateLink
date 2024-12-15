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
            tbPassword.UseSystemPasswordChar = true;
            this.Controls.Add(tbPassword);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            List<User> users = LoadUsersFromJson("users.json");

            User loggedInUser = ValidateUser(users);

            if (loggedInUser == null)
            {
                MessageBox.Show("Incorrect username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MainForm mainForm = new MainForm(isAdmin,loggedInUser,myBuilding);
                mainForm.Show();
                this.Hide();
            }
        }

        private User ValidateUser(List<User> users)
        {
            foreach (User user in users)
            {
                if (user.Username == tbUsername.Text && user.Password == tbPassword.Text)
                {
                    isAdmin = user.Role == Role.ADMIN;
                    return user;
                }
            }
            return null;
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
            myBuilding = new Building("Student Housing B.V.",6);
            isAdmin = false;
        }
    }
}
