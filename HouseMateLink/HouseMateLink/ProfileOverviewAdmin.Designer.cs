namespace HouseMateLink
{
    partial class ProfileOverviewAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            UserInfoPanel = new Panel();
            btnBack = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            tbAddName = new TextBox();
            cbAddRole = new ComboBox();
            tbAddUsername = new TextBox();
            pbNewUser = new PictureBox();
            btnAdduser = new Button();
            label7 = new Label();
            tbAddPassword = new TextBox();
            label11 = new Label();
            btnSelectPhotoAdd = new Button();
            groupBox2 = new GroupBox();
            cbRoom = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbNewUser).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(351, 9);
            label1.Name = "label1";
            label1.Size = new Size(446, 67);
            label1.TabIndex = 1;
            label1.Text = "Profile Overview";
            // 
            // UserInfoPanel
            // 
            UserInfoPanel.Location = new Point(47, 109);
            UserInfoPanel.Margin = new Padding(2);
            UserInfoPanel.Name = "UserInfoPanel";
            UserInfoPanel.Size = new Size(750, 591);
            UserInfoPanel.TabIndex = 10;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gold;
            btnBack.FlatAppearance.BorderColor = Color.Black;
            btnBack.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(47, 41);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(133, 33);
            btnBack.TabIndex = 11;
            btnBack.Text = "Home";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(55, 479);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 12;
            label3.Text = "Room:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(60, 427);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 13;
            label2.Text = "Role:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(50, 258);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 11;
            label4.Text = "Name:";
            // 
            // tbAddName
            // 
            tbAddName.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            tbAddName.Location = new Point(136, 255);
            tbAddName.Name = "tbAddName";
            tbAddName.Size = new Size(116, 30);
            tbAddName.TabIndex = 14;
            // 
            // cbAddRole
            // 
            cbAddRole.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            cbAddRole.FormattingEnabled = true;
            cbAddRole.Items.AddRange(new object[] { "Admin", "Tenant" });
            cbAddRole.Location = new Point(136, 424);
            cbAddRole.Name = "cbAddRole";
            cbAddRole.Size = new Size(116, 31);
            cbAddRole.TabIndex = 15;
            cbAddRole.SelectedIndexChanged += cbAddRole_SelectedIndexChanged;
            // 
            // tbAddUsername
            // 
            tbAddUsername.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            tbAddUsername.Location = new Point(136, 311);
            tbAddUsername.Name = "tbAddUsername";
            tbAddUsername.Size = new Size(116, 30);
            tbAddUsername.TabIndex = 18;
            // 
            // pbNewUser
            // 
            pbNewUser.Location = new Point(84, 33);
            pbNewUser.Name = "pbNewUser";
            pbNewUser.Size = new Size(110, 136);
            pbNewUser.SizeMode = PictureBoxSizeMode.Zoom;
            pbNewUser.TabIndex = 11;
            pbNewUser.TabStop = false;
            // 
            // btnAdduser
            // 
            btnAdduser.BackColor = Color.Gold;
            btnAdduser.FlatStyle = FlatStyle.Popup;
            btnAdduser.Location = new Point(70, 532);
            btnAdduser.Name = "btnAdduser";
            btnAdduser.Size = new Size(140, 33);
            btnAdduser.TabIndex = 11;
            btnAdduser.Text = "Add User";
            btnAdduser.UseVisualStyleBackColor = false;
            btnAdduser.Click += btnAdduser_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.Location = new Point(24, 318);
            label7.Name = "label7";
            label7.Size = new Size(102, 23);
            label7.TabIndex = 17;
            label7.Text = "Username:";
            // 
            // tbAddPassword
            // 
            tbAddPassword.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            tbAddPassword.Location = new Point(136, 372);
            tbAddPassword.Name = "tbAddPassword";
            tbAddPassword.Size = new Size(116, 30);
            tbAddPassword.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label11.Location = new Point(24, 375);
            label11.Name = "label11";
            label11.Size = new Size(97, 23);
            label11.TabIndex = 19;
            label11.Text = "Password:";
            // 
            // btnSelectPhotoAdd
            // 
            btnSelectPhotoAdd.BackColor = Color.Gold;
            btnSelectPhotoAdd.FlatStyle = FlatStyle.Popup;
            btnSelectPhotoAdd.Location = new Point(50, 192);
            btnSelectPhotoAdd.Name = "btnSelectPhotoAdd";
            btnSelectPhotoAdd.Size = new Size(182, 33);
            btnSelectPhotoAdd.TabIndex = 21;
            btnSelectPhotoAdd.Text = "Select photo";
            btnSelectPhotoAdd.UseVisualStyleBackColor = false;
            btnSelectPhotoAdd.Click += btnSelectPhoto_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(cbRoom);
            groupBox2.Controls.Add(btnSelectPhotoAdd);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(tbAddPassword);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btnAdduser);
            groupBox2.Controls.Add(pbNewUser);
            groupBox2.Controls.Add(tbAddUsername);
            groupBox2.Controls.Add(cbAddRole);
            groupBox2.Controls.Add(tbAddName);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(828, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(279, 591);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add user";
            // 
            // cbRoom
            // 
            cbRoom.FormattingEnabled = true;
            cbRoom.Location = new Point(136, 474);
            cbRoom.Name = "cbRoom";
            cbRoom.Size = new Size(116, 33);
            cbRoom.TabIndex = 22;
            // 
            // ProfileOverviewAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1158, 725);
            Controls.Add(btnBack);
            Controls.Add(UserInfoPanel);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Name = "ProfileOverviewAdmin";
            Text = "ProfileOverviewAdmin";
            ((System.ComponentModel.ISupportInitialize)pbNewUser).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel UserInfoPanel;
        private Button btnBack;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox tbAddName;
        private ComboBox cbAddRole;
        private TextBox tbAddUsername;
        private PictureBox pbNewUser;
        private Button btnAdduser;
        private Label label7;
        private TextBox tbAddPassword;
        private Label label11;
        private Button btnSelectPhotoAdd;
        private GroupBox groupBox2;
        private ComboBox cbRoom;
    }
}