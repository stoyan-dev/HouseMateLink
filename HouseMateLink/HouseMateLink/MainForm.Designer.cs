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
            pbUser = new PictureBox();
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
            panelComplaint = new Panel();
            btnPostComplaint = new Button();
            tbCreateComplaint = new TextBox();
            tabHouseRules = new TabPage();
            btnEditRules = new Button();
            rulesTextBox = new TextBox();
            tabGroceryList = new TabPage();
            btnClearAllProducts = new Button();
            btnDeleteSelectedProduct = new Button();
            lbShoppingList = new ListBox();
            btnAddToTheList = new Button();
            tbAddGroceries = new TextBox();
            tabHome.SuspendLayout();
            tabHomePage.SuspendLayout();
            grbButtons.SuspendLayout();
            grbHome.SuspendLayout();
            gbProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            tabCalendar.SuspendLayout();
            tabAnnouncements.SuspendLayout();
            grbAnnouncements.SuspendLayout();
            tabComplaints.SuspendLayout();
            grbComplaints.SuspendLayout();
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
            tabHome.Location = new Point(1, 14);
            tabHome.Margin = new Padding(2);
            tabHome.Name = "tabHome";
            tabHome.SelectedIndex = 0;
            tabHome.Size = new Size(785, 549);
            tabHome.TabIndex = 0;
            // 
            // tabHomePage
            // 
            tabHomePage.BackColor = Color.DeepSkyBlue;
            tabHomePage.Controls.Add(grbButtons);
            tabHomePage.Controls.Add(grbHome);
            tabHomePage.Location = new Point(4, 34);
            tabHomePage.Margin = new Padding(2);
            tabHomePage.Name = "tabHomePage";
            tabHomePage.Padding = new Padding(2);
            tabHomePage.Size = new Size(777, 511);
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
            grbButtons.Location = new Point(292, 28);
            grbButtons.Margin = new Padding(2);
            grbButtons.Name = "grbButtons";
            grbButtons.Padding = new Padding(2);
            grbButtons.Size = new Size(449, 404);
            grbButtons.TabIndex = 3;
            grbButtons.TabStop = false;
            // 
            // btnProfileOverview
            // 
            btnProfileOverview.BackColor = Color.Gold;
            btnProfileOverview.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProfileOverview.Location = new Point(248, 284);
            btnProfileOverview.Margin = new Padding(2);
            btnProfileOverview.Name = "btnProfileOverview";
            btnProfileOverview.Size = new Size(176, 82);
            btnProfileOverview.TabIndex = 5;
            btnProfileOverview.Text = "Profile Overview";
            btnProfileOverview.UseVisualStyleBackColor = false;
            btnProfileOverview.Click += btnProfileOverview_Click;
            // 
            // btnGrocery
            // 
            btnGrocery.BackColor = Color.Gold;
            btnGrocery.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGrocery.Location = new Point(36, 284);
            btnGrocery.Margin = new Padding(2);
            btnGrocery.Name = "btnGrocery";
            btnGrocery.Size = new Size(170, 82);
            btnGrocery.TabIndex = 4;
            btnGrocery.Text = "Grocery List";
            btnGrocery.UseVisualStyleBackColor = false;
            btnGrocery.Click += btnGrocery_Click;
            // 
            // btnComplaints
            // 
            btnComplaints.BackColor = Color.Gold;
            btnComplaints.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnComplaints.Location = new Point(248, 172);
            btnComplaints.Margin = new Padding(2);
            btnComplaints.Name = "btnComplaints";
            btnComplaints.Size = new Size(176, 81);
            btnComplaints.TabIndex = 3;
            btnComplaints.Text = "Complaints";
            btnComplaints.UseVisualStyleBackColor = false;
            btnComplaints.Click += btnComplaints_Click;
            // 
            // btnAnnouncements
            // 
            btnAnnouncements.BackColor = Color.Gold;
            btnAnnouncements.Font = new Font("Times New Roman", 14F, FontStyle.Italic);
            btnAnnouncements.Location = new Point(36, 172);
            btnAnnouncements.Margin = new Padding(2);
            btnAnnouncements.Name = "btnAnnouncements";
            btnAnnouncements.Size = new Size(170, 81);
            btnAnnouncements.TabIndex = 2;
            btnAnnouncements.Text = "Announcements";
            btnAnnouncements.UseVisualStyleBackColor = false;
            btnAnnouncements.Click += btnAnnouncements_Click;
            // 
            // btnCalendar
            // 
            btnCalendar.BackColor = Color.Gold;
            btnCalendar.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCalendar.Location = new Point(248, 44);
            btnCalendar.Margin = new Padding(2);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(176, 88);
            btnCalendar.TabIndex = 1;
            btnCalendar.Text = "Calendar";
            btnCalendar.UseVisualStyleBackColor = false;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // btnRules
            // 
            btnRules.BackColor = Color.Gold;
            btnRules.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRules.Location = new Point(36, 44);
            btnRules.Margin = new Padding(2);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(170, 88);
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
            grbHome.Location = new Point(32, 28);
            grbHome.Margin = new Padding(2);
            grbHome.Name = "grbHome";
            grbHome.Padding = new Padding(2);
            grbHome.Size = new Size(231, 404);
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
            gbProfile.Controls.Add(pbUser);
            gbProfile.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbProfile.Location = new Point(6, 28);
            gbProfile.Margin = new Padding(4);
            gbProfile.Name = "gbProfile";
            gbProfile.Padding = new Padding(4);
            gbProfile.Size = new Size(225, 170);
            gbProfile.TabIndex = 4;
            gbProfile.TabStop = false;
            gbProfile.Text = "Your profile";
            // 
            // lblUserRoom
            // 
            lblUserRoom.AutoSize = true;
            lblUserRoom.Location = new Point(128, 146);
            lblUserRoom.Margin = new Padding(4, 0, 4, 0);
            lblUserRoom.Name = "lblUserRoom";
            lblUserRoom.Size = new Size(19, 20);
            lblUserRoom.TabIndex = 6;
            lblUserRoom.Text = "..";
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Location = new Point(128, 102);
            lblUserRole.Margin = new Padding(4, 0, 4, 0);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(19, 20);
            lblUserRole.TabIndex = 5;
            lblUserRole.Text = "..";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(128, 45);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(19, 20);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "..";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 82);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Role:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 122);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 2;
            label5.Text = "Room:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(118, 25);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 1;
            label6.Text = "Name:";
            // 
            // pbUser
            // 
            pbUser.Location = new Point(6, 36);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(75, 76);
            pbUser.TabIndex = 0;
            pbUser.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 260);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(219, 38);
            label3.TabIndex = 3;
            label3.Text = "Phone: 0123456789";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 202);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(219, 52);
            label2.TabIndex = 2;
            label2.Text = "Email: stoyandev@yahoo.com";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 172);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 1;
            label1.Text = "Contact:";
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Gold;
            btnLogOut.Font = new Font("Times New Roman", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = SystemColors.ActiveCaptionText;
            btnLogOut.Location = new Point(34, 316);
            btnLogOut.Margin = new Padding(2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(139, 71);
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
            tabCalendar.Location = new Point(4, 34);
            tabCalendar.Margin = new Padding(2);
            tabCalendar.Name = "tabCalendar";
            tabCalendar.Padding = new Padding(2);
            tabCalendar.Size = new Size(777, 511);
            tabCalendar.TabIndex = 1;
            tabCalendar.Text = "Calendar";
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.DeepSkyBlue;
            monthCalendar1.Font = new Font("Segoe UI", 12F);
            monthCalendar1.Location = new Point(16, 40);
            monthCalendar1.Margin = new Padding(11);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.TrailingForeColor = Color.Gold;
            // 
            // tabAnnouncements
            // 
            tabAnnouncements.BackColor = Color.DeepSkyBlue;
            tabAnnouncements.Controls.Add(grbAnnouncements);
            tabAnnouncements.Location = new Point(4, 34);
            tabAnnouncements.Margin = new Padding(4);
            tabAnnouncements.Name = "tabAnnouncements";
            tabAnnouncements.Padding = new Padding(4);
            tabAnnouncements.Size = new Size(777, 511);
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
            grbAnnouncements.Location = new Point(4, 4);
            grbAnnouncements.Margin = new Padding(4);
            grbAnnouncements.Name = "grbAnnouncements";
            grbAnnouncements.Padding = new Padding(4);
            grbAnnouncements.Size = new Size(768, 496);
            grbAnnouncements.TabIndex = 1;
            grbAnnouncements.TabStop = false;
            grbAnnouncements.Text = "Announcements";
            grbAnnouncements.Enter += grbAnnouncements_Enter;
            // 
            // panelAnnouncements
            // 
            panelAnnouncements.BackColor = Color.GhostWhite;
            panelAnnouncements.Location = new Point(8, 38);
            panelAnnouncements.Margin = new Padding(4);
            panelAnnouncements.Name = "panelAnnouncements";
            panelAnnouncements.Size = new Size(752, 335);
            panelAnnouncements.TabIndex = 5;
            // 
            // btnCreateAnnouncement
            // 
            btnCreateAnnouncement.BackColor = Color.Gold;
            btnCreateAnnouncement.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAnnouncement.Location = new Point(274, 438);
            btnCreateAnnouncement.Margin = new Padding(4);
            btnCreateAnnouncement.Name = "btnCreateAnnouncement";
            btnCreateAnnouncement.Size = new Size(176, 51);
            btnCreateAnnouncement.TabIndex = 4;
            btnCreateAnnouncement.Text = "Create";
            btnCreateAnnouncement.UseVisualStyleBackColor = false;
            btnCreateAnnouncement.Click += btnCreateAnnouncement_Click;
            // 
            // tbAnnouncement
            // 
            tbAnnouncement.Location = new Point(25, 380);
            tbAnnouncement.Margin = new Padding(4);
            tbAnnouncement.Multiline = true;
            tbAnnouncement.Name = "tbAnnouncement";
            tbAnnouncement.Size = new Size(684, 49);
            tbAnnouncement.TabIndex = 1;
            // 
            // tabComplaints
            // 
            tabComplaints.BackColor = Color.DeepSkyBlue;
            tabComplaints.Controls.Add(grbComplaints);
            tabComplaints.Location = new Point(4, 34);
            tabComplaints.Margin = new Padding(4);
            tabComplaints.Name = "tabComplaints";
            tabComplaints.Padding = new Padding(4);
            tabComplaints.Size = new Size(777, 511);
            tabComplaints.TabIndex = 3;
            tabComplaints.Text = "Complaints";
            // 
            // grbComplaints
            // 
            grbComplaints.BackColor = Color.GhostWhite;
            grbComplaints.Controls.Add(panelComplaint);
            grbComplaints.Controls.Add(btnPostComplaint);
            grbComplaints.Controls.Add(tbCreateComplaint);
            grbComplaints.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            grbComplaints.Location = new Point(20, 25);
            grbComplaints.Margin = new Padding(4);
            grbComplaints.Name = "grbComplaints";
            grbComplaints.Padding = new Padding(4);
            grbComplaints.Size = new Size(731, 479);
            grbComplaints.TabIndex = 0;
            grbComplaints.TabStop = false;
            grbComplaints.Text = "Complaints";
            // 
            // panelComplaint
            // 
            panelComplaint.Location = new Point(8, 36);
            panelComplaint.Name = "panelComplaint";
            panelComplaint.Size = new Size(715, 347);
            panelComplaint.TabIndex = 6;
            // 
            // btnPostComplaint
            // 
            btnPostComplaint.BackColor = Color.Gold;
            btnPostComplaint.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPostComplaint.Location = new Point(522, 414);
            btnPostComplaint.Margin = new Padding(4);
            btnPostComplaint.Name = "btnPostComplaint";
            btnPostComplaint.Size = new Size(201, 44);
            btnPostComplaint.TabIndex = 5;
            btnPostComplaint.Text = "Post";
            btnPostComplaint.UseVisualStyleBackColor = false;
            btnPostComplaint.Click += btnPostComplaint_Click;
            // 
            // tbCreateComplaint
            // 
            tbCreateComplaint.Location = new Point(8, 390);
            tbCreateComplaint.Margin = new Padding(4);
            tbCreateComplaint.Multiline = true;
            tbCreateComplaint.Name = "tbCreateComplaint";
            tbCreateComplaint.Size = new Size(492, 66);
            tbCreateComplaint.TabIndex = 2;
            // 
            // tabHouseRules
            // 
            tabHouseRules.BackColor = Color.DeepSkyBlue;
            tabHouseRules.Controls.Add(btnEditRules);
            tabHouseRules.Controls.Add(rulesTextBox);
            tabHouseRules.Location = new Point(4, 34);
            tabHouseRules.Margin = new Padding(2);
            tabHouseRules.Name = "tabHouseRules";
            tabHouseRules.Size = new Size(777, 511);
            tabHouseRules.TabIndex = 4;
            tabHouseRules.Text = "House Rules";
            // 
            // btnEditRules
            // 
            btnEditRules.BackColor = Color.Gold;
            btnEditRules.Location = new Point(314, 445);
            btnEditRules.Margin = new Padding(4);
            btnEditRules.Name = "btnEditRules";
            btnEditRules.Size = new Size(131, 40);
            btnEditRules.TabIndex = 5;
            btnEditRules.Text = "Edit Rules";
            btnEditRules.UseVisualStyleBackColor = false;
            btnEditRules.Click += btnEditRules_Click;
            // 
            // rulesTextBox
            // 
            rulesTextBox.Font = new Font("Courier New", 10F);
            rulesTextBox.Location = new Point(30, 28);
            rulesTextBox.Margin = new Padding(4);
            rulesTextBox.Multiline = true;
            rulesTextBox.Name = "rulesTextBox";
            rulesTextBox.ScrollBars = ScrollBars.Vertical;
            rulesTextBox.Size = new Size(716, 394);
            rulesTextBox.TabIndex = 3;
            // 
            // tabGroceryList
            // 
            tabGroceryList.BackColor = Color.DeepSkyBlue;
            tabGroceryList.Controls.Add(btnClearAllProducts);
            tabGroceryList.Controls.Add(btnDeleteSelectedProduct);
            tabGroceryList.Controls.Add(lbShoppingList);
            tabGroceryList.Controls.Add(btnAddToTheList);
            tabGroceryList.Controls.Add(tbAddGroceries);
            tabGroceryList.Location = new Point(4, 34);
            tabGroceryList.Margin = new Padding(2);
            tabGroceryList.Name = "tabGroceryList";
            tabGroceryList.Size = new Size(777, 511);
            tabGroceryList.TabIndex = 5;
            tabGroceryList.Text = "Grocery List";
            // 
            // btnClearAllProducts
            // 
            btnClearAllProducts.BackColor = Color.Gold;
            btnClearAllProducts.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnClearAllProducts.Location = new Point(326, 342);
            btnClearAllProducts.Name = "btnClearAllProducts";
            btnClearAllProducts.Size = new Size(225, 36);
            btnClearAllProducts.TabIndex = 5;
            btnClearAllProducts.Text = "Clear all products";
            btnClearAllProducts.UseVisualStyleBackColor = false;
            btnClearAllProducts.Click += btnClearAllProducts_Click;
            // 
            // btnDeleteSelectedProduct
            // 
            btnDeleteSelectedProduct.BackColor = Color.Gold;
            btnDeleteSelectedProduct.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnDeleteSelectedProduct.Location = new Point(136, 428);
            btnDeleteSelectedProduct.Margin = new Padding(4);
            btnDeleteSelectedProduct.Name = "btnDeleteSelectedProduct";
            btnDeleteSelectedProduct.Size = new Size(225, 36);
            btnDeleteSelectedProduct.TabIndex = 4;
            btnDeleteSelectedProduct.Text = "Delete selected product";
            btnDeleteSelectedProduct.UseVisualStyleBackColor = false;
            btnDeleteSelectedProduct.Click += btnClearSelectedProduct_Click;
            // 
            // lbShoppingList
            // 
            lbShoppingList.BackColor = Color.White;
            lbShoppingList.FormattingEnabled = true;
            lbShoppingList.ItemHeight = 25;
            lbShoppingList.Location = new Point(136, 142);
            lbShoppingList.Margin = new Padding(4);
            lbShoppingList.Name = "lbShoppingList";
            lbShoppingList.Size = new Size(466, 254);
            lbShoppingList.TabIndex = 3;
            // 
            // btnAddToTheList
            // 
            btnAddToTheList.BackColor = Color.Gold;
            btnAddToTheList.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnAddToTheList.Location = new Point(458, 48);
            btnAddToTheList.Margin = new Padding(4);
            btnAddToTheList.Name = "btnAddToTheList";
            btnAddToTheList.Size = new Size(160, 36);
            btnAddToTheList.TabIndex = 1;
            btnAddToTheList.Text = "Add";
            btnAddToTheList.UseVisualStyleBackColor = false;
            btnAddToTheList.Click += btnAddToTheList_Click;
            // 
            // tbAddGroceries
            // 
            tbAddGroceries.BackColor = Color.White;
            tbAddGroceries.Location = new Point(101, 50);
            tbAddGroceries.Margin = new Padding(4);
            tbAddGroceries.Name = "tbAddGroceries";
            tbAddGroceries.Size = new Size(239, 31);
            tbAddGroceries.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 566);
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
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            tabCalendar.ResumeLayout(false);
            tabAnnouncements.ResumeLayout(false);
            grbAnnouncements.ResumeLayout(false);
            grbAnnouncements.PerformLayout();
            tabComplaints.ResumeLayout(false);
            grbComplaints.ResumeLayout(false);
            grbComplaints.PerformLayout();
            tabHouseRules.ResumeLayout(false);
            tabHouseRules.PerformLayout();
            tabGroceryList.ResumeLayout(false);
            tabGroceryList.PerformLayout();
            ResumeLayout(false);
        }

        //kati e mrusen top

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
        private PictureBox pbUser;
        private GroupBox grbComplaints;
        private Button btnPostComplaint;
        private TextBox tbCreateComplaint;
        private Button btnEditRules;
        private TextBox rulesTextBox;
        private MonthCalendar monthCalendar1;
        private ListBox lbShoppingList;
        private Button btnAddToTheList;
        private TextBox tbAddGroceries;
        private Button btnDeleteSelectedProduct;
        private Button btnClearAllProducts;
        private GroupBox grbAnnouncements;
        private Panel panelAnnouncements;
        private Button btnCreateAnnouncement;
        private TextBox tbAnnouncement;
        private Panel panelComplaint;
    }
}