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
            if(!ValidateUser(myBuilding.GetUsers()))
            {
                MessageBox.Show("Incorrect username or password!");
            }
            else
            {
                MainForm mainForm = new MainForm(isAdmin);
                mainForm.Show();
                this.Close();
            }
        }

        private bool ValidateUser(List<User> users)
        {
            foreach(User user in users)
            {
                if (user.Username == tbUsername.Text && user.Password == tbPassword.Text)
                {
                    if (user.Role == Role.ADMIN)
                    {
                        isAdmin = true;
                    }
                    else
                    {
                        isAdmin = false;
                    }
                    return true;
                }
            }
            return false;
        }

        private void Initialization()
        {
            myBuilding = new Building("Student Housing B.V.");
            isAdmin = false;
        }
    }
}
