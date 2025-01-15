using System;
using System.Diagnostics;
using System.Windows.Forms;
using HouseMateLink.Data;

namespace HouseMateLink
{
    public partial class AnnouncementMessageControl : System.Windows.Forms.UserControl
    {
        private Label lblAnnouncementText;
        private Label lblAnnouncementDate;
        private Label lblUserName;
        private Button btnArchive;
        private Action<AnnouncementMessageControl> onArchiveButtonClick;
        private DBHelper myDBHelper;
        private int id;
        public AnnouncementMessageControl(string announcementText, DateTime createdAt, string username , User user, Action<AnnouncementMessageControl> onArchiveButtonClick, int id)
        {
            InitializeComponent();
            this.onArchiveButtonClick = onArchiveButtonClick;
            this.id = id;
            InitializeAnnouncementControl(announcementText, createdAt, username ,user);
            myDBHelper = new DBHelper();
        }

        private void InitializeAnnouncementControl(string announcementText, DateTime createdAt, string username,User user)
        {
            this.BackColor = Color.Gold;
            this.Padding = new Padding(10);
            this.Size = new Size(640, 500);

            lblAnnouncementText = new Label
            {
                Text = announcementText,
                Size = new Size(500, 50),
                Location = new Point(10, 10),
                Font = new Font("Arial", 10, FontStyle.Regular),
                ForeColor = Color.Black
            };

            lblAnnouncementDate = new Label
            {
                Text = $"Created at: {createdAt.ToShortDateString()}",
                AutoSize = true,
                Location = new Point(10, lblAnnouncementText.Bottom),
                Font = new Font("Arial", 8, FontStyle.Italic),
                ForeColor = Color.Gray
            };

            lblUserName = new Label
            {
                Text = $"Created by: {username}",
                AutoSize = true,
                Location = new Point(10, lblAnnouncementDate.Bottom),
                Font = new Font("Arial", 8, FontStyle.Italic),
                ForeColor = Color.Gray
            };

            btnArchive = new Button
            {
                Text = "Archive",
                Location = new Point(10, lblUserName.Bottom + 10),
                Size = new Size(130, 35),
                Font = new Font("Arial", 12, FontStyle.Italic),
                BackColor = Color.GhostWhite
            };

            if (user.Role==Role.TENANT)
            {
                btnArchive.Visible = false;
                Debug.WriteLine("Admin is false: Archive button hidden.");
            }
            else
            {
                btnArchive.Click += BtnArchive_Click;
                Debug.WriteLine("Admin is true: Archive button shown and event bound.");
            }

            this.Controls.Add(lblAnnouncementText);
            this.Controls.Add(lblAnnouncementDate);
            this.Controls.Add(lblUserName);
            this.Controls.Add(btnArchive);
        }
        private void BtnArchive_Click(object sender, EventArgs e)
        {
            myDBHelper.ChangeAnnouncementStatus(this.id);
            onArchiveButtonClick(this);
        }

        private void AnnouncementMessageControl_Load(object sender, EventArgs e)
        {

        }
    }
}