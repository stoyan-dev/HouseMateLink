namespace HouseMateLink
{
    public partial class UserInfoSummaryControl : UserControl
    {
        private PictureBox pbPhoto;
        private Label lblName;
        private Label lblRole;
        private Label lblRoom;

        public UserInfoSummaryControl(string name, Role role, int room, Image photo)
        {
            InitializeComponent();
            InitializeUserInfoSummary(name, role, room, photo);
        }

        private void InitializeUserInfoSummary(string name, Role role, int room, Image photo)
        {
            this.Size = new Size(200, 250);
            this.BackColor = Color.White;
            this.Padding = new Padding(10);
            this.BorderStyle = BorderStyle.FixedSingle;

            // Set the photo size and position
            pbPhoto = new PictureBox
            {
                Size = new Size(100, 100),
                Location = new Point(50, 10),
                Image = photo,
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Set the name label
            lblName = new Label
            {
                Text = name,
                Font = new Font("Arial", 12, FontStyle.Bold),
                AutoSize = true,  // AutoSize set to true to adjust based on the text size
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(10, 120),  // Position below the photo
                Width = 180 // Ensure the label has enough width to accommodate the text
            };

            // Set the role label
            lblRole = new Label
            {
                Text = $"Role: {role}",
                Font = new Font("Arial", 10),
                AutoSize = true,  // AutoSize set to true to adjust based on the text size
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(10, 160),  // Position below the name
                Width = 180 // Ensure the label has enough width to accommodate the text
            };

            // Set the room label
            lblRoom = new Label
            {
                Text = $"Room: {room}",
                Font = new Font("Arial", 10),
                AutoSize = true,  // AutoSize set to true to adjust based on the text size
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(10, 190),  // Position below the role
                Width = 180 // Ensure the label has enough width to accommodate the text
            };

            // Add the controls to the UserControl
            this.Controls.Add(pbPhoto);
            this.Controls.Add(lblName);
            this.Controls.Add(lblRole);
            this.Controls.Add(lblRoom);
        }
    }
}

