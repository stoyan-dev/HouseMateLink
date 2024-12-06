namespace HouseMateLink
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dateTimePicker;


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
            tabHome = new TabControl();
            tabHomePage = new TabPage();
            grbButtons = new GroupBox();
            btnProfileOverview = new Button();
            btnGrocery = new Button();
            btnComplaints = new Button();
            btnAnnouncements = new Button();
            btnCalendar = new Button();
            btnRules = new Button();
            grbHome = new GroupBox();
            gbProfile = new GroupBox();
            lblUserRoom = new Label();
            lblUserRole = new Label();
            lblUserName = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnLogOut = new Button();
            tabCalendar = new TabPage();
            monthCalendar1 = new MonthCalendar();
            tabAnnouncements = new TabPage();
            grbAnnouncements = new GroupBox();
            panelAnnouncements = new Panel();
            btnCreateAnnouncement = new Button();
            tbAnnouncement = new TextBox();
            tabComplaints = new TabPage();
            grbComplaints = new GroupBox();
            gbComplaint = new GroupBox();
            label8 = new Label();
            lblDatePosted = new Label();
            lblComplaint = new Label();
            btnPostComplaint = new Button();
            tbCreateComplaint = new TextBox();
            tabHouseRules = new TabPage();
            btnEditRules = new Button();
            rulesTextBox = new TextBox();
            tabGroceryList = new TabPage();
            btnClearAllProducts = new Button();
            btnClearTheLastProduct = new Button();
            lbShoppingList = new ListBox();
            lblInfo = new Label();
            btnAddToTheList = new Button();
            tbAddGroceries = new TextBox();
            tabHome.SuspendLayout();
            tabHomePage.SuspendLayout();
            grbButtons.SuspendLayout();
            grbHome.SuspendLayout();
            gbProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabCalendar.SuspendLayout();
            tabAnnouncements.SuspendLayout();
            grbAnnouncements.SuspendLayout();
            tabComplaints.SuspendLayout();
            grbComplaints.SuspendLayout();
            gbComplaint.SuspendLayout();
            tabHouseRules.SuspendLayout();
            tabGroceryList.SuspendLayout();
            SuspendLayout();
            // 
            // tabHome
            // 
            tabHome.Controls.Add(tabHomePage);
            tabHome.Controls.Add(tabCalendar);
            tabHome.Controls.Add(tabAnnouncements);
            tabHome.Controls.Add(tabComplaints);
            tabHome.Controls.Add(tabHouseRules);
            tabHome.Controls.Add(tabGroceryList);
            tabHome.Location = new Point(1, 11);
            tabHome.Margin = new Padding(2);
            tabHome.Name = "tabHome";
            tabHome.SelectedIndex = 0;
            tabHome.Size = new Size(628, 439);
            tabHome.TabIndex = 0;
            // 
            // tabHomePage
            // 
            tabHomePage.BackColor = Color.DeepSkyBlue;
            tabHomePage.Controls.Add(grbButtons);
            tabHomePage.Controls.Add(grbHome);
            tabHomePage.Location = new Point(4, 29);
            tabHomePage.Margin = new Padding(2);
            tabHomePage.Name = "tabHomePage";
            tabHomePage.Padding = new Padding(2);
            tabHomePage.Size = new Size(620, 406);
            tabHomePage.TabIndex = 0;
            tabHomePage.Text = "Home Page";
            // 
            // grbButtons
            // 
            grbButtons.BackColor = Color.GhostWhite;
            grbButtons.Controls.Add(btnProfileOverview);
            grbButtons.Controls.Add(btnGrocery);
            grbButtons.Controls.Add(btnComplaints);
            grbButtons.Controls.Add(btnAnnouncements);
            grbButtons.Controls.Add(btnCalendar);
            grbButtons.Controls.Add(btnRules);
            grbButtons.Location = new Point(234, 22);
            grbButtons.Margin = new Padding(2);
            grbButtons.Name = "grbButtons";
            grbButtons.Padding = new Padding(2);
            grbButtons.Size = new Size(359, 323);
            grbButtons.TabIndex = 3;
            grbButtons.TabStop = false;
            // 
            // btnProfileOverview
            // 
            btnProfileOverview.BackColor = Color.Gold;
            btnProfileOverview.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProfileOverview.Location = new Point(198, 227);
            btnProfileOverview.Margin = new Padding(2);
            btnProfileOverview.Name = "btnProfileOverview";
            btnProfileOverview.Size = new Size(141, 66);
            btnProfileOverview.TabIndex = 5;
            btnProfileOverview.Text = "Profile Overview";
            btnProfileOverview.UseVisualStyleBackColor = false;
            btnProfileOverview.Click += btnProfileOverview_Click;
            // 
            // btnGrocery
            // 
            btnGrocery.BackColor = Color.Gold;
            btnGrocery.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGrocery.Location = new Point(29, 227);
            btnGrocery.Margin = new Padding(2);
            btnGrocery.Name = "btnGrocery";
            btnGrocery.Size = new Size(136, 66);
            btnGrocery.TabIndex = 4;
            btnGrocery.Text = "Grocery List";
            btnGrocery.UseVisualStyleBackColor = false;
            btnGrocery.Click += btnGrocery_Click;
            // 
            // btnComplaints
            // 
            btnComplaints.BackColor = Color.Gold;
            btnComplaints.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnComplaints.Location = new Point(198, 138);
            btnComplaints.Margin = new Padding(2);
            btnComplaints.Name = "btnComplaints";
            btnComplaints.Size = new Size(141, 65);
            btnComplaints.TabIndex = 3;
            btnComplaints.Text = "Complaints";
            btnComplaints.UseVisualStyleBackColor = false;
            btnComplaints.Click += btnComplaints_Click;
            // 
            // btnAnnouncements
            // 
            btnAnnouncements.BackColor = Color.Gold;
            btnAnnouncements.Font = new Font("Times New Roman", 14F, FontStyle.Italic);
            btnAnnouncements.Location = new Point(29, 138);
            btnAnnouncements.Margin = new Padding(2);
            btnAnnouncements.Name = "btnAnnouncements";
            btnAnnouncements.Size = new Size(136, 65);
            btnAnnouncements.TabIndex = 2;
            btnAnnouncements.Text = "Announcements";
            btnAnnouncements.UseVisualStyleBackColor = false;
            btnAnnouncements.Click += btnAnnouncements_Click;
            // 
            // btnCalendar
            // 
            btnCalendar.BackColor = Color.Gold;
            btnCalendar.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCalendar.Location = new Point(198, 35);
            btnCalendar.Margin = new Padding(2);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(141, 70);
            btnCalendar.TabIndex = 1;
            btnCalendar.Text = "Calendar";
            btnCalendar.UseVisualStyleBackColor = false;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // btnRules
            // 
            btnRules.BackColor = Color.Gold;
            btnRules.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRules.Location = new Point(29, 35);
            btnRules.Margin = new Padding(2);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(136, 70);
            btnRules.TabIndex = 0;
            btnRules.Text = "House Rules";
            btnRules.UseVisualStyleBackColor = false;
            btnRules.Click += btnRules_Click;
            // 
            // grbHome
            // 
            grbHome.BackColor = Color.GhostWhite;
            grbHome.Controls.Add(gbProfile);
            grbHome.Controls.Add(label3);
            grbHome.Controls.Add(label2);
            grbHome.Controls.Add(label1);
            grbHome.Controls.Add(btnLogOut);
            grbHome.Font = new Font("Times New Roman", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grbHome.Location = new Point(26, 22);
            grbHome.Margin = new Padding(2);
            grbHome.Name = "grbHome";
            grbHome.Padding = new Padding(2);
            grbHome.Size = new Size(185, 323);
            grbHome.TabIndex = 2;
            grbHome.TabStop = false;
            grbHome.Text = "Student Housing B.V.";
            grbHome.Enter += grbHome_Enter;
            // 
            // gbProfile
            // 
            gbProfile.BackColor = Color.White;
            gbProfile.Controls.Add(lblUserRoom);
            gbProfile.Controls.Add(lblUserRole);
            gbProfile.Controls.Add(lblUserName);
            gbProfile.Controls.Add(label4);
            gbProfile.Controls.Add(label5);
            gbProfile.Controls.Add(label6);
            gbProfile.Controls.Add(pictureBox1);
            gbProfile.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbProfile.Location = new Point(5, 22);
            gbProfile.Name = "gbProfile";
            gbProfile.Size = new Size(180, 136);
            gbProfile.TabIndex = 4;
            gbProfile.TabStop = false;
            gbProfile.Text = "Your profile";
            // 
            // lblUserRoom
            // 
            lblUserRoom.AutoSize = true;
            lblUserRoom.Location = new Point(102, 117);
            lblUserRoom.Name = "lblUserRoom";
            lblUserRoom.Size = new Size(16, 17);
            lblUserRoom.TabIndex = 6;
            lblUserRoom.Text = "..";
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Location = new Point(102, 82);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(16, 17);
            lblUserRole.TabIndex = 5;
            lblUserRole.Text = "..";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(102, 36);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(16, 17);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "..";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 66);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 3;
            label4.Text = "Role:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 98);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 2;
            label5.Text = "Room:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 20);
            label6.Name = "label6";
            label6.Size = new Size(51, 17);
            label6.TabIndex = 1;
            label6.Text = "Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(6, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 76);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(5, 208);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(175, 30);
            label3.TabIndex = 3;
            label3.Text = "Phone: 0123456789";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 162);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(175, 42);
            label2.TabIndex = 2;
            label2.Text = "Email: stoyandev@yahoo.com";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 138);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 1;
            label1.Text = "Contact:";
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Gold;
            btnLogOut.Font = new Font("Times New Roman", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = SystemColors.ActiveCaptionText;
            btnLogOut.Location = new Point(27, 253);
            btnLogOut.Margin = new Padding(2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(111, 57);
            btnLogOut.TabIndex = 0;
            btnLogOut.TabStop = false;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // tabCalendar
            // 
            tabCalendar.BackColor = Color.DeepSkyBlue;
            tabCalendar.Controls.Add(monthCalendar1);
            tabCalendar.Location = new Point(4, 29);
            tabCalendar.Margin = new Padding(2);
            tabCalendar.Name = "tabCalendar";
            tabCalendar.Padding = new Padding(2);
            tabCalendar.Size = new Size(620, 406);
            tabCalendar.TabIndex = 1;
            tabCalendar.Text = "Calendar";
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.DeepSkyBlue;
            monthCalendar1.Font = new Font("Segoe UI", 12F);
            monthCalendar1.Location = new Point(13, 32);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.TrailingForeColor = Color.Gold;
            // 
            // tabAnnouncements
            // 
            tabAnnouncements.BackColor = Color.DeepSkyBlue;
            tabAnnouncements.Controls.Add(grbAnnouncements);
            tabAnnouncements.Location = new Point(4, 29);
            tabAnnouncements.Name = "tabAnnouncements";
            tabAnnouncements.Padding = new Padding(3);
            tabAnnouncements.Size = new Size(620, 406);
            tabAnnouncements.TabIndex = 2;
            tabAnnouncements.Text = "Announcements";
            // 
            // grbAnnouncements
            // 
            grbAnnouncements.BackColor = Color.DeepSkyBlue;
            grbAnnouncements.Controls.Add(panelAnnouncements);
            grbAnnouncements.Controls.Add(btnCreateAnnouncement);
            grbAnnouncements.Controls.Add(tbAnnouncement);
            grbAnnouncements.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbAnnouncements.Location = new Point(3, 3);
            grbAnnouncements.Name = "grbAnnouncements";
            grbAnnouncements.Size = new Size(614, 397);
            grbAnnouncements.TabIndex = 1;
            grbAnnouncements.TabStop = false;
            grbAnnouncements.Text = "Announcements";
            grbAnnouncements.Enter += grbAnnouncements_Enter;
            // 
            // panelAnnouncements
            // 
            panelAnnouncements.Location = new Point(6, 30);
            panelAnnouncements.Name = "panelAnnouncements";
            panelAnnouncements.Size = new Size(602, 268);
            panelAnnouncements.TabIndex = 5;
            // 
            // btnCreateAnnouncement
            // 
            btnCreateAnnouncement.BackColor = Color.Gold;
            btnCreateAnnouncement.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAnnouncement.Location = new Point(219, 350);
            btnCreateAnnouncement.Name = "btnCreateAnnouncement";
            btnCreateAnnouncement.Size = new Size(141, 41);
            btnCreateAnnouncement.TabIndex = 4;
            btnCreateAnnouncement.Text = "Create";
            btnCreateAnnouncement.UseVisualStyleBackColor = false;
            btnCreateAnnouncement.Click += btnCreateAnnouncement_Click;
            // 
            // tbAnnouncement
            // 
            tbAnnouncement.Location = new Point(20, 304);
            tbAnnouncement.Multiline = true;
            tbAnnouncement.Name = "tbAnnouncement";
            tbAnnouncement.Size = new Size(548, 40);
            tbAnnouncement.TabIndex = 1;
            // 
            // tabComplaints
            // 
            tabComplaints.BackColor = Color.DeepSkyBlue;
            tabComplaints.Controls.Add(grbComplaints);
            tabComplaints.Location = new Point(4, 29);
            tabComplaints.Name = "tabComplaints";
            tabComplaints.Padding = new Padding(3);
            tabComplaints.Size = new Size(620, 406);
            tabComplaints.TabIndex = 3;
            tabComplaints.Text = "Complaints";
            // 
            // grbComplaints
            // 
            grbComplaints.BackColor = Color.GhostWhite;
            grbComplaints.Controls.Add(gbComplaint);
            grbComplaints.Controls.Add(btnPostComplaint);
            grbComplaints.Controls.Add(tbCreateComplaint);
            grbComplaints.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            grbComplaints.Location = new Point(16, 20);
            grbComplaints.Name = "grbComplaints";
            grbComplaints.Size = new Size(585, 383);
            grbComplaints.TabIndex = 0;
            grbComplaints.TabStop = false;
            grbComplaints.Text = "Complaints";
            // 
            // gbComplaint
            // 
            gbComplaint.Controls.Add(label8);
            gbComplaint.Controls.Add(lblDatePosted);
            gbComplaint.Controls.Add(lblComplaint);
            gbComplaint.Location = new Point(6, 52);
            gbComplaint.Name = "gbComplaint";
            gbComplaint.Size = new Size(225, 126);
            gbComplaint.TabIndex = 7;
            gbComplaint.TabStop = false;
            gbComplaint.Text = "Complaint";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold);
            label8.Location = new Point(111, 90);
            label8.Name = "label8";
            label8.Size = new Size(17, 17);
            label8.TabIndex = 2;
            label8.Text = "...";
            // 
            // lblDatePosted
            // 
            lblDatePosted.AutoSize = true;
            lblDatePosted.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold);
            lblDatePosted.Location = new Point(20, 90);
            lblDatePosted.Name = "lblDatePosted";
            lblDatePosted.Size = new Size(73, 17);
            lblDatePosted.TabIndex = 1;
            lblDatePosted.Text = "Posted on:";
            // 
            // lblComplaint
            // 
            lblComplaint.AutoSize = true;
            lblComplaint.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold);
            lblComplaint.Location = new Point(20, 52);
            lblComplaint.Name = "lblComplaint";
            lblComplaint.Size = new Size(17, 17);
            lblComplaint.TabIndex = 0;
            lblComplaint.Text = "...";
            // 
            // btnPostComplaint
            // 
            btnPostComplaint.BackColor = Color.Gold;
            btnPostComplaint.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPostComplaint.Location = new Point(418, 331);
            btnPostComplaint.Name = "btnPostComplaint";
            btnPostComplaint.Size = new Size(161, 35);
            btnPostComplaint.TabIndex = 5;
            btnPostComplaint.Text = "Post";
            btnPostComplaint.UseVisualStyleBackColor = false;
            // 
            // tbCreateComplaint
            // 
            tbCreateComplaint.Location = new Point(6, 312);
            tbCreateComplaint.Multiline = true;
            tbCreateComplaint.Name = "tbCreateComplaint";
            tbCreateComplaint.Size = new Size(394, 54);
            tbCreateComplaint.TabIndex = 2;
            // 
            // tabHouseRules
            // 
            tabHouseRules.BackColor = Color.DeepSkyBlue;
            tabHouseRules.Controls.Add(btnEditRules);
            tabHouseRules.Controls.Add(rulesTextBox);
            tabHouseRules.Location = new Point(4, 29);
            tabHouseRules.Margin = new Padding(2);
            tabHouseRules.Name = "tabHouseRules";
            tabHouseRules.Size = new Size(620, 406);
            tabHouseRules.TabIndex = 4;
            tabHouseRules.Text = "House Rules";
            // 
            // btnEditRules
            // 
            btnEditRules.BackColor = Color.Gold;
            btnEditRules.Location = new Point(256, 354);
            btnEditRules.Name = "btnEditRules";
            btnEditRules.Size = new Size(105, 32);
            btnEditRules.TabIndex = 5;
            btnEditRules.Text = "Edit Rules";
            btnEditRules.UseVisualStyleBackColor = false;
            btnEditRules.Click += btnEditRules_Click;
            // 
            // rulesTextBox
            // 
            rulesTextBox.Font = new Font("Courier New", 10F);
            rulesTextBox.Location = new Point(24, 22);
            rulesTextBox.Multiline = true;
            rulesTextBox.Name = "rulesTextBox";
            rulesTextBox.ScrollBars = ScrollBars.Vertical;
            rulesTextBox.Size = new Size(574, 316);
            rulesTextBox.TabIndex = 3;
            // 
            // tabGroceryList
            // 
            tabGroceryList.BackColor = Color.DeepSkyBlue;
            tabGroceryList.Controls.Add(btnClearAllProducts);
            tabGroceryList.Controls.Add(btnClearTheLastProduct);
            tabGroceryList.Controls.Add(lbShoppingList);
            tabGroceryList.Controls.Add(lblInfo);
            tabGroceryList.Controls.Add(btnAddToTheList);
            tabGroceryList.Controls.Add(tbAddGroceries);
            tabGroceryList.Location = new Point(4, 29);
            tabGroceryList.Margin = new Padding(2);
            tabGroceryList.Name = "tabGroceryList";
            tabGroceryList.Size = new Size(620, 406);
            tabGroceryList.TabIndex = 5;
            tabGroceryList.Text = "Grocery List";
            // 
            // btnClearAllProducts
            // 
            btnClearAllProducts.BackColor = Color.Gold;
            btnClearAllProducts.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnClearAllProducts.Location = new Point(303, 342);
            btnClearAllProducts.Name = "btnClearAllProducts";
            btnClearAllProducts.Size = new Size(180, 29);
            btnClearAllProducts.TabIndex = 5;
            btnClearAllProducts.Text = "Clear all products";
            btnClearAllProducts.UseVisualStyleBackColor = false;
            btnClearAllProducts.Click += btnClearAllProducts_Click;
            // 
            // btnClearTheLastProduct
            // 
            btnClearTheLastProduct.BackColor = Color.Gold;
            btnClearTheLastProduct.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnClearTheLastProduct.Location = new Point(109, 342);
            btnClearTheLastProduct.Name = "btnClearTheLastProduct";
            btnClearTheLastProduct.Size = new Size(180, 29);
            btnClearTheLastProduct.TabIndex = 4;
            btnClearTheLastProduct.Text = "Clear the last product";
            btnClearTheLastProduct.UseVisualStyleBackColor = false;
            btnClearTheLastProduct.Click += btnClearTheLastProduct_Click;
            // 
            // lbShoppingList
            // 
            lbShoppingList.BackColor = Color.Gold;
            lbShoppingList.FormattingEnabled = true;
            lbShoppingList.Location = new Point(109, 114);
            lbShoppingList.Name = "lbShoppingList";
            lbShoppingList.Size = new Size(374, 204);
            lbShoppingList.TabIndex = 3;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblInfo.Location = new Point(69, 71);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(451, 23);
            lblInfo.TabIndex = 2;
            lblInfo.Text = "Here you can add the necessary groceries for the house";
            // 
            // btnAddToTheList
            // 
            btnAddToTheList.BackColor = Color.Gold;
            btnAddToTheList.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnAddToTheList.Location = new Point(366, 25);
            btnAddToTheList.Name = "btnAddToTheList";
            btnAddToTheList.Size = new Size(128, 29);
            btnAddToTheList.TabIndex = 1;
            btnAddToTheList.Text = "Add";
            btnAddToTheList.UseVisualStyleBackColor = false;
            btnAddToTheList.Click += btnAddToTheList_Click;
            // 
            // tbAddGroceries
            // 
            tbAddGroceries.BackColor = Color.Gold;
            tbAddGroceries.Location = new Point(81, 27);
            tbAddGroceries.Name = "tbAddGroceries";
            tbAddGroceries.Size = new Size(192, 27);
            tbAddGroceries.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(640, 453);
            Controls.Add(tabHome);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "HouseMateLink";
            tabHome.ResumeLayout(false);
            tabHomePage.ResumeLayout(false);
            grbButtons.ResumeLayout(false);
            grbHome.ResumeLayout(false);
            grbHome.PerformLayout();
            gbProfile.ResumeLayout(false);
            gbProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabCalendar.ResumeLayout(false);
            tabAnnouncements.ResumeLayout(false);
            grbAnnouncements.ResumeLayout(false);
            grbAnnouncements.PerformLayout();
            tabComplaints.ResumeLayout(false);
            grbComplaints.ResumeLayout(false);
            grbComplaints.PerformLayout();
            gbComplaint.ResumeLayout(false);
            gbComplaint.PerformLayout();
            tabHouseRules.ResumeLayout(false);
            tabHouseRules.PerformLayout();
            tabGroceryList.ResumeLayout(false);
            tabGroceryList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabHome;
        private TabPage tabHomePage;
        private GroupBox grbButtons;
        private Button btnProfileOverview;
        private Button btnGrocery;
        private Button btnComplaints;
        private Button btnAnnouncements;
        private Button btnCalendar;
        private Button btnRules;
        private GroupBox grbHome;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnLogOut;
        private TabPage tabCalendar;
        private TabPage tabAnnouncements;
        private TabPage tabComplaints;
        private TabPage tabHouseRules;
        private TabPage tabGroceryList;
        private GroupBox gbProfile;
        private Label lblUserRoom;
        private Label lblUserRole;
        private Label lblUserName;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private GroupBox grbComplaints;
        private Button btnPostComplaint;
        private TextBox tbCreateComplaint;
        private GroupBox gbComplaint;
        private Label label8;
        private Label lblDatePosted;
        private Label lblComplaint;
        private Button btnEditRules;
        private TextBox rulesTextBox;
        private MonthCalendar monthCalendar1;
        private ListBox lbShoppingList;
        private Label lblInfo;
        private Button btnAddToTheList;
        private TextBox tbAddGroceries;
        private Button btnClearTheLastProduct;
        private Button btnClearAllProducts;
        private GroupBox grbAnnouncements;
        private Panel panelAnnouncements;
        private Button btnCreateAnnouncement;
        private TextBox tbAnnouncement;
    }
}