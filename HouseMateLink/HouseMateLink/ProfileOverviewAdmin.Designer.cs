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
            groupBox2 = new GroupBox();
            btnSelectPhotoAdd = new Button();
            tbAddPassword = new TextBox();
            label11 = new Label();
            tbAddUsername = new TextBox();
            label7 = new Label();
            btnAdduser = new Button();
            nudAddRoom = new NumericUpDown();
            pbNewUser = new PictureBox();
            cbAddRole = new ComboBox();
            tbAddName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            UserInfoPanel = new Panel();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAddRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNewUser).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(439, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(533, 81);
            label1.TabIndex = 1;
            label1.Text = "Profile Overview";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnSelectPhotoAdd);
            groupBox2.Controls.Add(tbAddPassword);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(tbAddUsername);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btnAdduser);
            groupBox2.Controls.Add(nudAddRoom);
            groupBox2.Controls.Add(pbNewUser);
            groupBox2.Controls.Add(cbAddRole);
            groupBox2.Controls.Add(tbAddName);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(1035, 136);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(349, 739);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add user";
            // 
            // btnSelectPhotoAdd
            // 
            btnSelectPhotoAdd.BackColor = Color.Gold;
            btnSelectPhotoAdd.FlatStyle = FlatStyle.Popup;
            btnSelectPhotoAdd.Location = new Point(62, 240);
            btnSelectPhotoAdd.Margin = new Padding(4);
            btnSelectPhotoAdd.Name = "btnSelectPhotoAdd";
            btnSelectPhotoAdd.Size = new Size(228, 41);
            btnSelectPhotoAdd.TabIndex = 21;
            btnSelectPhotoAdd.Text = "Select photo";
            btnSelectPhotoAdd.UseVisualStyleBackColor = false;
            btnSelectPhotoAdd.Click += btnSelectPhoto_Click;
            // 
            // tbAddPassword
            // 
            tbAddPassword.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            tbAddPassword.Location = new Point(170, 590);
            tbAddPassword.Margin = new Padding(4);
            tbAddPassword.Name = "tbAddPassword";
            tbAddPassword.Size = new Size(144, 35);
            tbAddPassword.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label11.Location = new Point(18, 599);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(118, 26);
            label11.TabIndex = 19;
            label11.Text = "Password:";
            // 
            // tbAddUsername
            // 
            tbAddUsername.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            tbAddUsername.Location = new Point(170, 525);
            tbAddUsername.Margin = new Padding(4);
            tbAddUsername.Name = "tbAddUsername";
            tbAddUsername.Size = new Size(144, 35);
            tbAddUsername.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.Location = new Point(18, 534);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(123, 26);
            label7.TabIndex = 17;
            label7.Text = "Username:";
            // 
            // btnAdduser
            // 
            btnAdduser.BackColor = Color.Gold;
            btnAdduser.FlatStyle = FlatStyle.Popup;
            btnAdduser.Location = new Point(88, 665);
            btnAdduser.Margin = new Padding(4);
            btnAdduser.Name = "btnAdduser";
            btnAdduser.Size = new Size(175, 41);
            btnAdduser.TabIndex = 11;
            btnAdduser.Text = "Add User";
            btnAdduser.UseVisualStyleBackColor = false;
            btnAdduser.Click += btnAdduser_Click;
            // 
            // nudAddRoom
            // 
            nudAddRoom.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            nudAddRoom.Location = new Point(170, 454);
            nudAddRoom.Margin = new Padding(4);
            nudAddRoom.Name = "nudAddRoom";
            nudAddRoom.Size = new Size(145, 35);
            nudAddRoom.TabIndex = 16;
            // 
            // pbNewUser
            // 
            pbNewUser.Location = new Point(105, 41);
            pbNewUser.Margin = new Padding(4);
            pbNewUser.Name = "pbNewUser";
            pbNewUser.Size = new Size(138, 170);
            pbNewUser.SizeMode = PictureBoxSizeMode.Zoom;
            pbNewUser.TabIndex = 11;
            pbNewUser.TabStop = false;
            // 
            // cbAddRole
            // 
            cbAddRole.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            cbAddRole.FormattingEnabled = true;
            cbAddRole.Items.AddRange(new object[] { "Admin", "Tenant" });
            cbAddRole.Location = new Point(170, 388);
            cbAddRole.Margin = new Padding(4);
            cbAddRole.Name = "cbAddRole";
            cbAddRole.Size = new Size(144, 34);
            cbAddRole.TabIndex = 15;
            // 
            // tbAddName
            // 
            tbAddName.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            tbAddName.Location = new Point(170, 319);
            tbAddName.Margin = new Padding(4);
            tbAddName.Name = "tbAddName";
            tbAddName.Size = new Size(144, 35);
            tbAddName.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(62, 330);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 26);
            label4.TabIndex = 11;
            label4.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(62, 398);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 26);
            label2.TabIndex = 13;
            label2.Text = "Role:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(62, 462);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 26);
            label3.TabIndex = 12;
            label3.Text = "Room:";
            // 
            // UserInfoPanel
            // 
            UserInfoPanel.Location = new Point(59, 136);
            UserInfoPanel.Name = "UserInfoPanel";
            UserInfoPanel.Size = new Size(940, 739);
            UserInfoPanel.TabIndex = 10;
            // 
            // ProfileOverviewAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1448, 906);
            Controls.Add(UserInfoPanel);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "ProfileOverviewAdmin";
            Text = "ProfileOverviewAdmin";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAddRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNewUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox2;
        private Button btnAdduser;
        private NumericUpDown nudAddRoom;
        private PictureBox pbNewUser;
        private ComboBox cbAddRole;
        private TextBox tbAddName;
        private Label label4;
        private Label label2;
        private Label label3;
        private TextBox tbAddUsername;
        private Label label7;
        private TextBox tbAddPassword;
        private Label label11;
        private Button btnSelectPhotoAdd;
        private Panel UserInfoPanel;
    }
}