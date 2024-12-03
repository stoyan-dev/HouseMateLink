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
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            pbUser = new PictureBox();
            tbUserName = new TextBox();
            cbRole = new ComboBox();
            nudRoom = new NumericUpDown();
            groupBox2 = new GroupBox();
            btnEdit = new Button();
            pbNewUser = new PictureBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAdduser = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRoom).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbNewUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(215, 22);
            label1.Name = "label1";
            label1.Size = new Size(348, 52);
            label1.TabIndex = 1;
            label1.Text = "Profile Overview";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
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
            groupBox1.Size = new Size(288, 154);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "User1";
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
            pbUser.Size = new Size(75, 76);
            pbUser.TabIndex = 0;
            pbUser.TabStop = false;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(158, 33);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(88, 25);
            tbUserName.TabIndex = 7;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(158, 70);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(88, 25);
            cbRole.TabIndex = 8;
            // 
            // nudRoom
            // 
            nudRoom.Location = new Point(158, 108);
            nudRoom.Name = "nudRoom";
            nudRoom.Size = new Size(88, 25);
            nudRoom.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnAdduser);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(pbNewUser);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(491, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(279, 444);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add user";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Gold;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Location = new Point(6, 118);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 30);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // pbNewUser
            // 
            pbNewUser.Location = new Point(92, 51);
            pbNewUser.Name = "pbNewUser";
            pbNewUser.Size = new Size(86, 113);
            pbNewUser.TabIndex = 11;
            pbNewUser.TabStop = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            numericUpDown1.Location = new Point(133, 303);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(88, 30);
            numericUpDown1.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Tenant" });
            comboBox1.Location = new Point(133, 250);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(88, 31);
            comboBox1.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            textBox1.Location = new Point(133, 195);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(88, 30);
            textBox1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(47, 258);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 13;
            label2.Text = "Role:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(47, 310);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 12;
            label3.Text = "Room:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(47, 204);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 11;
            label4.Text = "Name:";
            // 
            // btnAdduser
            // 
            btnAdduser.BackColor = Color.Gold;
            btnAdduser.FlatStyle = FlatStyle.Popup;
            btnAdduser.Location = new Point(70, 379);
            btnAdduser.Name = "btnAdduser";
            btnAdduser.Size = new Size(140, 33);
            btnAdduser.TabIndex = 11;
            btnAdduser.Text = "Add User";
            btnAdduser.UseVisualStyleBackColor = false;
            // 
            // ProfileOverviewAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(811, 577);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "ProfileOverviewAdmin";
            Text = "ProfileOverviewAdmin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRoom).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbNewUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private NumericUpDown numericUpDown1;
        private PictureBox pbNewUser;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label4;
        private Label label2;
        private Label label3;
    }
}