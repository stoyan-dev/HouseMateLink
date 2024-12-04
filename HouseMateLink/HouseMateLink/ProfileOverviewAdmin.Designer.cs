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
            groupBox1 = new GroupBox();
            btnEditPhoto = new Button();
            tbUserPassword = new TextBox();
            tbUserUsername = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnEdit = new Button();
            nudRoom = new NumericUpDown();
            cbRole = new ComboBox();
            tbUserName = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            pbUser = new PictureBox();
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
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
            label1.Location = new Point(351, 9);
            label1.Name = "label1";
            label1.Size = new Size(446, 67);
            label1.TabIndex = 1;
            label1.Text = "Profile Overview";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnEditPhoto);
            groupBox1.Controls.Add(tbUserPassword);
            groupBox1.Controls.Add(tbUserUsername);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(nudRoom);
            groupBox1.Controls.Add(cbRole);
            groupBox1.Controls.Add(tbUserName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(pbUser);
            groupBox1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 264);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "User1";
            // 
            // btnEditPhoto
            // 
            btnEditPhoto.BackColor = Color.Gold;
            btnEditPhoto.FlatStyle = FlatStyle.Popup;
            btnEditPhoto.Location = new Point(6, 184);
            btnEditPhoto.Name = "btnEditPhoto";
            btnEditPhoto.Size = new Size(75, 55);
            btnEditPhoto.TabIndex = 15;
            btnEditPhoto.Text = "Edit photo";
            btnEditPhoto.UseVisualStyleBackColor = false;
            btnEditPhoto.Click += btnEditPhoto_Click;
            // 
            // tbUserPassword
            // 
            tbUserPassword.Location = new Point(186, 181);
            tbUserPassword.Name = "tbUserPassword";
            tbUserPassword.Size = new Size(88, 25);
            tbUserPassword.TabIndex = 14;
            // 
            // tbUserUsername
            // 
            tbUserUsername.Location = new Point(186, 144);
            tbUserUsername.Name = "tbUserUsername";
            tbUserUsername.Size = new Size(88, 25);
            tbUserUsername.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 184);
            label6.Name = "label6";
            label6.Size = new Size(75, 17);
            label6.TabIndex = 12;
            label6.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 147);
            label5.Name = "label5";
            label5.Size = new Size(80, 17);
            label5.TabIndex = 11;
            label5.Text = "Username:";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Gold;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Location = new Point(199, 228);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 30);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // nudRoom
            // 
            nudRoom.Location = new Point(158, 108);
            nudRoom.Name = "nudRoom";
            nudRoom.Size = new Size(88, 25);
            nudRoom.TabIndex = 9;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(158, 70);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(88, 25);
            cbRole.TabIndex = 8;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(158, 33);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(88, 25);
            tbUserName.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(100, 73);
            label8.Name = "label8";
            label8.Size = new Size(44, 17);
            label8.TabIndex = 3;
            label8.Text = "Role:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(100, 110);
            label9.Name = "label9";
            label9.Size = new Size(52, 17);
            label9.TabIndex = 2;
            label9.Text = "Room:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(101, 36);
            label10.Name = "label10";
            label10.Size = new Size(51, 17);
            label10.TabIndex = 1;
            label10.Text = "Name:";
            // 
            // pbUser
            // 
            pbUser.Location = new Point(6, 33);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(75, 116);
            pbUser.TabIndex = 0;
            pbUser.TabStop = false;
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
            groupBox2.Location = new Point(828, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(279, 591);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add user";
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
            // tbAddPassword
            // 
            tbAddPassword.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            tbAddPassword.Location = new Point(136, 472);
            tbAddPassword.Name = "tbAddPassword";
            tbAddPassword.Size = new Size(116, 30);
            tbAddPassword.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label11.Location = new Point(14, 479);
            label11.Name = "label11";
            label11.Size = new Size(97, 23);
            label11.TabIndex = 19;
            label11.Text = "Password:";
            // 
            // tbAddUsername
            // 
            tbAddUsername.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            tbAddUsername.Location = new Point(136, 420);
            tbAddUsername.Name = "tbAddUsername";
            tbAddUsername.Size = new Size(116, 30);
            tbAddUsername.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.Location = new Point(14, 427);
            label7.Name = "label7";
            label7.Size = new Size(102, 23);
            label7.TabIndex = 17;
            label7.Text = "Username:";
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
            // 
            // nudAddRoom
            // 
            nudAddRoom.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            nudAddRoom.Location = new Point(136, 363);
            nudAddRoom.Name = "nudAddRoom";
            nudAddRoom.Size = new Size(116, 30);
            nudAddRoom.TabIndex = 16;
            // 
            // pbNewUser
            // 
            pbNewUser.Location = new Point(84, 33);
            pbNewUser.Name = "pbNewUser";
            pbNewUser.Size = new Size(110, 136);
            pbNewUser.TabIndex = 11;
            pbNewUser.TabStop = false;
            // 
            // cbAddRole
            // 
            cbAddRole.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            cbAddRole.FormattingEnabled = true;
            cbAddRole.Items.AddRange(new object[] { "Admin", "Tenant" });
            cbAddRole.Location = new Point(136, 310);
            cbAddRole.Name = "cbAddRole";
            cbAddRole.Size = new Size(116, 31);
            cbAddRole.TabIndex = 15;
            // 
            // tbAddName
            // 
            tbAddName.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            tbAddName.Location = new Point(136, 255);
            tbAddName.Name = "tbAddName";
            tbAddName.Size = new Size(116, 30);
            tbAddName.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(50, 264);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 11;
            label4.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(50, 318);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 13;
            label2.Text = "Role:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(50, 370);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 12;
            label3.Text = "Room:";
            // 
            // ProfileOverviewAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1158, 725);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "ProfileOverviewAdmin";
            Text = "ProfileOverviewAdmin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAddRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNewUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnEdit;
        private NumericUpDown nudRoom;
        private ComboBox cbRole;
        private TextBox tbUserName;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox pbUser;
        private GroupBox groupBox2;
        private Button btnAdduser;
        private NumericUpDown nudAddRoom;
        private PictureBox pbNewUser;
        private ComboBox cbAddRole;
        private TextBox tbAddName;
        private Label label4;
        private Label label2;
        private Label label3;
        private TextBox tbUserUsername;
        private Label label6;
        private Label label5;
        private TextBox tbUserPassword;
        private TextBox tbAddUsername;
        private Label label7;
        private TextBox tbAddPassword;
        private Label label11;
        private Button btnSelectPhotoAdd;
        private Button btnEditPhoto;
    }
}