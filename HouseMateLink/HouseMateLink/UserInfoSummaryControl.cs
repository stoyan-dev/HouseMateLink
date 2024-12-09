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
            this.BackColor = Color.White;
            this.Padding = new Padding(10);
            this.BorderStyle = BorderStyle.FixedSingle;

            pbPhoto = new PictureBox
            {
                Size = new Size(100, 100),
                Location = new Point(50, 10),
                Image = photo,
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle
            };

            lblName = new Label
            {
                Text = name,
                Font = new Font("Arial", 12, FontStyle.Bold),
                AutoSize = true,  
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(10, 120),  
                Width = 180 
            };

            lblRole = new Label
            {
                Text = $"Role: {role}",
                Font = new Font("Arial", 10),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(10, 160),
                Width = 180
            };

            lblRoom = new Label
            {
                Text = $"Room: {room}",
                Font = new Font("Arial", 10),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(10, 190),  
                Width = 180 
            };

            this.Controls.Add(pbPhoto);
            this.Controls.Add(lblName);
            this.Controls.Add(lblRole);
            this.Controls.Add(lblRoom);
        }
    }
}

