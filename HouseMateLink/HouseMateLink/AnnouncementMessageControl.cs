using System;
using System.Windows.Forms;

namespace HouseMateLink
{
    public partial class AnnouncementMessageControl : UserControl
    {
        private Label lblAnnouncementText;
        private Label lblAnnouncementDate;
        private Label lblUserName;
        public AnnouncementMessageControl(string announcementText, DateTime createdAt, string userName)
        {
            InitializeComponent();
            InitializeAnnouncementControl(announcementText, createdAt, userName);
        }

        private void InitializeAnnouncementControl(string announcementText, DateTime createdAt, string userName)
        {
            this.BackColor = Color.Gold; 
            this.Padding = new Padding(10); 

            lblAnnouncementText = new Label
            {
                Text = announcementText, 
                AutoSize = true, 
                Location = new Point(10, 10), 
                Font = new Font("Arial", 10, FontStyle.Regular), 
                ForeColor = Color.Black 
            };

            lblAnnouncementDate = new Label
            {
                Text = $"Created at: {createdAt.ToShortDateString()}", 
                AutoSize = true, 
                Location = new Point(10, 40), 
                Font = new Font("Arial", 8, FontStyle.Italic), 
                ForeColor = Color.Gray
            };

            lblUserName = new Label
            {
                Text = $"Created by: {userName}",
                AutoSize = true,
                Location = new Point(10, 60),
                Font = new Font("Arial", 8, FontStyle.Italic),
                ForeColor = Color.Gray 
            };

            this.Controls.Add(lblAnnouncementText);
            this.Controls.Add(lblAnnouncementDate);
            this.Controls.Add(lblUserName);
        }
    }
}