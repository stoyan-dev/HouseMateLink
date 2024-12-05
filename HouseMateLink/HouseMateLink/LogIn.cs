namespace HouseMateLink
{
    public partial class logIn : Form
    {
        //private Building my
        private User newUser;
        private bool isTenant;
        public logIn()
        {
            InitializeComponent();
            Initialization();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //ValidateUser(tbUsername.Text,tbPassword.Text);
           // MainForm homeForm = new MainForm();
        }

        //private bool ValidateUser(List<User> users)
        //{
        //    if(users.Contains(newUser))
        //    {
                 
        //    }
        //    foreach (User user in users)
        //    {
        //        if (newUser.Username == user.Username && newUser.Password == user.Password)
        //        {
        //            if (newUser.Role == Role.ADMIN)
        //            {
        //                isTenant = false;
        //            }
        //            else
        //            {
        //                isTenant = true;
        //            }
        //            return true;
        //        }
        //        return false;
        //    }
        //}

        private void Initialization()
        {
            newUser = new User("kate", "123", "katerina", Role.ADMIN, 0, "photo");
            isTenant = false;
        }
    }
}
