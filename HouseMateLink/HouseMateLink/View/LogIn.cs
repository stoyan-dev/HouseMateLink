using System;
using System.Text.Json;
using HouseMateLink.Data;

namespace HouseMateLink
{
    public partial class logIn : Form
    {
        private Building myBuilding;
        private DBHelper myDBHelper;
        private bool isAdmin;

        private void logIn_Form_Closing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        public logIn()
        {
            InitializeComponent();
            Initialization();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //List<User> users = LoadUsersFromJson("users.json");

            User loggedInUser = myDBHelper.ValidateUser(tbUsername.Text,tbPassword.Text);

            if (loggedInUser == null)
            {
                MessageBox.Show("Incorrect username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CheckRole(loggedInUser);
                MainForm mainForm = new MainForm(isAdmin,loggedInUser,myBuilding);
                mainForm.Show();
                this.Hide();
            }
        }

        //private List<User> LoadUsersFromJson(string filePath)
        //{
        //    try
        //    {
        //        if (File.Exists(filePath))
        //        {
        //            string jsonString = File.ReadAllText(filePath);
        //            return JsonSerializer.Deserialize<List<User>>(jsonString);
        //        }
        //        else
        //        {
        //            MessageBox.Show("User file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return new List<User>();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error reading user file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return new List<User>();
        //    }
        //}


        public void CheckRole(User user)
        {
            if(user.Role==Role.ADMIN) isAdmin = true;
            if (user.Role == Role.TENANT) isAdmin = false;
        }

        private void Initialization()
        {
            myBuilding = new Building("Student Housing B.V.",6);
            myDBHelper = new DBHelper();
            isAdmin = false;
            tbPassword.UseSystemPasswordChar = true;
            this.Controls.Add(tbPassword);
        }
    }
}
