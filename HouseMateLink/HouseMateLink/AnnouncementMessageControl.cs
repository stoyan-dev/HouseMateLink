using System;
using System.Windows.Forms;

namespace HouseMateLink
{
    public partial class AnnouncementMessageControl : UserControl
    {
        private Label lblAnnouncementText;
        private Label lblAnnouncementDate;
        public AnnouncementMessageControl(string announcementText, DateTime createdAt)
        {
            InitializeComponent();
            InitializeAnnouncementControl(announcementText, createdAt);
        }

        private void InitializeAnnouncementControl(string announcementText, DateTime createdAt)
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

            this.Controls.Add(lblAnnouncementText);
            this.Controls.Add(lblAnnouncementDate);
        }
    }
}