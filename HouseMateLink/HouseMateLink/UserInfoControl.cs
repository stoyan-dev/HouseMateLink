using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseMateLink
{
    public partial class UserInfoControl : UserControl
    {
        private PictureBox pbUserPhoto;
        private Label lblUserName;
        private Label lblUserRole;
        private Label lblUserRoom;
        private Label lblUsername;
        private Label lblUserPassword;
        private Button btnRemoveUser;  

        private Action<UserInfoControl> onRemoveButtonClick;

        public UserInfoControl(string userName, string role, string room, string username, string password, Image userPhoto, Action<UserInfoControl> onRemoveButtonClick)
        {
            InitializeComponent();
            this.onRemoveButtonClick = onRemoveButtonClick;
            InitializeUserControl(userName, role, room, username, password, userPhoto);
        }

        private void InitializeUserControl(string userName, string role, string room, string username, string password, Image userPhoto)
        {
            this.BackColor = Color.GhostWhite;
            this.Padding = new Padding(10);

            pbUserPhoto = new PictureBox
            {
                Image = userPhoto,  
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(80, 80),
                Location = new Point(10, 10)  
            };

            lblUserName = new Label
            {
                Text = $"Name: {userName}",
                AutoSize = true,
                Location = new Point(100, 10),
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.Black
            };

            lblUserRole = new Label
            {
                Text = $"Role: {role}",
                AutoSize = true,
                Location = new Point(100, 30),
                Font = new Font("Arial", 9),
                ForeColor = Color.Black
            };

            lblUserRoom = new Label
            {
                Text = $"Room: {room}",
                AutoSize = true,
                Location = new Point(100, 50),
                Font = new Font("Arial", 9),
                ForeColor = Color.Black
            };

            lblUsername = new Label
            {
                Text = $"Username: {username}",
                AutoSize = true,
                Location = new Point(100, 70),
                Font = new Font("Arial", 9),
                ForeColor = Color.Black
            };

            lblUserPassword = new Label
            {
                Text = $"Password: {password}",  
                AutoSize = true,
                Location = new Point(100, 90),
                Font = new Font("Arial", 9),
                ForeColor = Color.Black
            };

            btnRemoveUser = new Button
            {
                Text = "Remove",
                Location = new Point(200, 120),
                Size = new Size(85, 30),
                BackColor = Color.Gold
            };

            btnRemoveUser.Click += BtnRemoveUser_Click;

            this.Controls.Add(lblUserName);
            this.Controls.Add(lblUserRole);
            this.Controls.Add(lblUserRoom);
            this.Controls.Add(lblUsername);
            this.Controls.Add(lblUserPassword);
            this.Controls.Add(pbUserPhoto);
            this.Controls.Add(btnRemoveUser);
        }

        private void BtnRemoveUser_Click(object sender, EventArgs e)
        {
            onRemoveButtonClick(this);
        }
    }
}
