using System;
using System.Windows.Forms;

namespace HouseMateLink
{
    public partial class AnnouncementMessageControl : UserControl
    {
        public AnnouncementMessageControl(string message)
        {
            InitializeComponent();
            CreateAnnouncementLabels(message);
        }

        private void CreateAnnouncementLabels(string message)
        {
            Label lblAnnouncement = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(20, 20),
                Text = message
            };

            Label lblDateCreated = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI", 8F),
                Location = new System.Drawing.Point(20, 50),
                Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt")  
            };

            
            Label lblNothing = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(15, 80),
                Text = "Created on:"
            };

            this.Controls.Add(lblAnnouncement);
            this.Controls.Add(lblDateCreated);
            this.Controls.Add(lblNothing);
        }
    }
}