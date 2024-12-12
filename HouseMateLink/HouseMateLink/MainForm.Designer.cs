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
            btnCreateAnnouncement = new Button();
            tbAnnouncement = new TextBox();
            panelAnnouncements = new Panel();
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
            tabHome.Location = new Point(1, 11);
            tabHome.Margin = new Padding(2);
            tabHome.Name = "tabHome";
            tabHome.SelectedIndex = 0;
            tabHome.Size = new Size(915, 547);
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
            tabHomePage.Size = new Size(907, 514);
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
            grbButtons.Location = new Point(525, 22);
            grbButtons.Margin = new Padding(2);
            grbButtons.Name = "grbButtons";
            grbButtons.Padding = new Padding(2);
            grbButtons.Size = new Size(357, 474);
            grbButtons.TabIndex = 3;
            grbButtons.TabStop = false;
            // 
            // btnProfileOverview
            // 
            btnProfileOverview.BackColor = Color.Gold;
            btnProfileOverview.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfileOverview.Location = new Point(14, 95);
            btnProfileOverview.Margin = new Padding(2);
            btnProfileOverview.Name = "btnProfileOverview";
            btnProfileOverview.Size = new Size(325, 59);
            btnProfileOverview.TabIndex = 5;
            btnProfileOverview.Text = "Profile Overview";
            btnProfileOverview.UseVisualStyleBackColor = false;
            btnProfileOverview.Click += btnProfileOverview_Click;
            // 
            // btnGrocery
            // 
            btnGrocery.BackColor = Color.Gold;
            btnGrocery.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGrocery.Location = new Point(14, 328);
            btnGrocery.Margin = new Padding(2);
            btnGrocery.Name = "btnGrocery";
            btnGrocery.Size = new Size(325, 59);
            btnGrocery.TabIndex = 4;
            btnGrocery.Text = "Grocery List";
            btnGrocery.UseVisualStyleBackColor = false;
            btnGrocery.Click += btnGrocery_Click;
            // 
            // btnComplaints
            // 
            btnComplaints.BackColor = Color.Gold;
            btnComplaints.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComplaints.Location = new Point(14, 173);
            btnComplaints.Margin = new Padding(2);
            btnComplaints.Name = "btnComplaints";
            btnComplaints.Size = new Size(325, 59);
            btnComplaints.TabIndex = 3;
            btnComplaints.Text = "Complaints";
            btnComplaints.UseVisualStyleBackColor = false;
            btnComplaints.Click += btnComplaints_Click;
            // 
            // btnAnnouncements
            // 
            btnAnnouncements.BackColor = Color.Gold;
            btnAnnouncements.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnnouncements.Location = new Point(14, 251);
            btnAnnouncements.Margin = new Padding(2);
            btnAnnouncements.Name = "btnAnnouncements";
            btnAnnouncements.Size = new Size(325, 59);
            btnAnnouncements.TabIndex = 2;
            btnAnnouncements.Text = "Announcements";
            btnAnnouncements.UseVisualStyleBackColor = false;
            btnAnnouncements.Click += btnAnnouncements_Click;
            // 
            // btnCalendar
            // 
            btnCalendar.BackColor = Color.Gold;
            btnCalendar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalendar.Location = new Point(14, 400);
            btnCalendar.Margin = new Padding(2);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(325, 59);
            btnCalendar.TabIndex = 1;
            btnCalendar.Text = "Calendar";
            btnCalendar.UseVisualStyleBackColor = false;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // btnRules
            // 
            btnRules.BackColor = Color.Gold;
            btnRules.FlatAppearance.BorderColor = Color.Black;
            btnRules.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRules.Location = new Point(14, 22);
            btnRules.Margin = new Padding(2);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(325, 59);
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
            grbHome.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic);
            grbHome.Location = new Point(26, 22);
            grbHome.Margin = new Padding(2);
            grbHome.Name = "grbHome";
            grbHome.Padding = new Padding(2);
            grbHome.Size = new Size(480, 474);
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
            gbProfile.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            gbProfile.Location = new Point(17, 39);
            gbProfile.Name = "gbProfile";
            gbProfile.Size = new Size(447, 261);
            gbProfile.TabIndex = 4;
            gbProfile.TabStop = false;
            gbProfile.Text = "Your profile";
            // 
            // lblUserRoom
            // 
            lblUserRoom.AutoSize = true;
            lblUserRoom.Font = new Font("Times New Roman", 13F);
            lblUserRoom.Location = new Point(229, 212);
            lblUserRoom.Name = "lblUserRoom";
            lblUserRoom.Size = new Size(24, 25);
            lblUserRoom.TabIndex = 6;
            lblUserRoom.Text = "..";
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Font = new Font("Times New Roman", 13F);
            lblUserRole.Location = new Point(229, 134);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(24, 25);
            lblUserRole.TabIndex = 5;
            lblUserRole.Text = "..";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Times New Roman", 13F);
            lblUserName.Location = new Point(229, 56);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(24, 25);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "..";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label4.Location = new Point(229, 105);
            label4.Name = "label4";
            label4.Size = new Size(67, 26);
            label4.TabIndex = 3;
            label4.Text = "Role:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label5.Location = new Point(229, 186);
            label5.Name = "label5";
            label5.Size = new Size(80, 26);
            label5.TabIndex = 2;
            label5.Text = "Room:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label6.Location = new Point(229, 29);
            label6.Name = "label6";
            label6.Size = new Size(79, 26);
            label6.TabIndex = 1;
            label6.Text = "Name:";
            // 
            // pbUser
            // 
            pbUser.Location = new Point(17, 29);
            pbUser.Margin = new Padding(2);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(197, 210);
            pbUser.TabIndex = 0;
            pbUser.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            label3.Location = new Point(17, 388);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(175, 30);
            label3.TabIndex = 3;
            label3.Text = "Phone: 0123456789";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            label2.Location = new Point(17, 338);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(198, 59);
            label2.TabIndex = 2;
            label2.Text = "Email: HousingBV@yahoo.com";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 303);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 1;
            label1.Text = "Contact:";
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Gold;
            btnLogOut.Font = new Font("Times New Roman", 13F, FontStyle.Bold | FontStyle.Italic);
            btnLogOut.ForeColor = SystemColors.ActiveCaptionText;
            btnLogOut.Location = new Point(17, 429);
            btnLogOut.Margin = new Padding(2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(134, 41);
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
            tabCalendar.Size = new Size(907, 514);
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
            tabAnnouncements.Size = new Size(907, 514);
            tabAnnouncements.TabIndex = 2;
            tabAnnouncements.Text = "Announcements";
            // 
            // grbAnnouncements
            // 
            grbAnnouncements.BackColor = Color.DeepSkyBlue;
            grbAnnouncements.Controls.Add(btnCreateAnnouncement);
            grbAnnouncements.Controls.Add(tbAnnouncement);
            grbAnnouncements.Controls.Add(panelAnnouncements);
            grbAnnouncements.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            grbAnnouncements.Location = new Point(7, 16);
            grbAnnouncements.Name = "grbAnnouncements";
            grbAnnouncements.Size = new Size(885, 483);
            grbAnnouncements.TabIndex = 1;
            grbAnnouncements.TabStop = false;
            grbAnnouncements.Text = "Announcements";
            grbAnnouncements.Enter += grbAnnouncements_Enter;
            // 
            // btnCreateAnnouncement
            // 
            btnCreateAnnouncement.BackColor = Color.Gold;
            btnCreateAnnouncement.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAnnouncement.Location = new Point(709, 433);
            btnCreateAnnouncement.Name = "btnCreateAnnouncement";
            btnCreateAnnouncement.Size = new Size(153, 44);
            btnCreateAnnouncement.TabIndex = 4;
            btnCreateAnnouncement.Text = "Create";
            btnCreateAnnouncement.UseVisualStyleBackColor = false;
            btnCreateAnnouncement.Click += btnCreateAnnouncement_Click;
            // 
            // tbAnnouncement
            // 
            tbAnnouncement.Location = new Point(22, 405);
            tbAnnouncement.Multiline = true;
            tbAnnouncement.Name = "tbAnnouncement";
            tbAnnouncement.Size = new Size(681, 72);
            tbAnnouncement.TabIndex = 1;
            // 
            // panelAnnouncements
            // 
            panelAnnouncements.BackColor = Color.GhostWhite;
            panelAnnouncements.Location = new Point(22, 39);
            panelAnnouncements.Name = "panelAnnouncements";
            panelAnnouncements.Size = new Size(840, 346);
            panelAnnouncements.TabIndex = 5;
            // 
            // tabComplaints
            // 
            tabComplaints.BackColor = Color.DeepSkyBlue;
            tabComplaints.Controls.Add(grbComplaints);
            tabComplaints.Location = new Point(4, 29);
            tabComplaints.Name = "tabComplaints";
            tabComplaints.Padding = new Padding(3);
            tabComplaints.Size = new Size(907, 514);
            tabComplaints.TabIndex = 3;
            tabComplaints.Text = "Complaints";
            // 
            // grbComplaints
            // 
            grbComplaints.BackColor = Color.DeepSkyBlue;
            grbComplaints.Controls.Add(panelComplaint);
            grbComplaints.Controls.Add(btnPostComplaint);
            grbComplaints.Controls.Add(tbCreateComplaint);
            grbComplaints.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            grbComplaints.Location = new Point(7, 17);
            grbComplaints.Name = "grbComplaints";
            grbComplaints.Size = new Size(885, 481);
            grbComplaints.TabIndex = 0;
            grbComplaints.TabStop = false;
            grbComplaints.Text = "Complaints";
            // 
            // panelComplaint
            // 
            panelComplaint.BackColor = Color.GhostWhite;
            panelComplaint.Location = new Point(19, 47);
            panelComplaint.Margin = new Padding(2);
            panelComplaint.Name = "panelComplaint";
            panelComplaint.Size = new Size(842, 332);
            panelComplaint.TabIndex = 6;
            // 
            // btnPostComplaint
            // 
            btnPostComplaint.BackColor = Color.Gold;
            btnPostComplaint.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPostComplaint.Location = new Point(706, 429);
            btnPostComplaint.Name = "btnPostComplaint";
            btnPostComplaint.Size = new Size(155, 43);
            btnPostComplaint.TabIndex = 5;
            btnPostComplaint.Text = "Post";
            btnPostComplaint.UseVisualStyleBackColor = false;
            btnPostComplaint.Click += btnPostComplaint_Click;
            // 
            // tbCreateComplaint
            // 
            tbCreateComplaint.Location = new Point(19, 399);
            tbCreateComplaint.Multiline = true;
            tbCreateComplaint.Name = "tbCreateComplaint";
            tbCreateComplaint.Size = new Size(681, 73);
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
            tabHouseRules.Size = new Size(907, 514);
            tabHouseRules.TabIndex = 4;
            tabHouseRules.Text = "House Rules";
            // 
            // btnEditRules
            // 
            btnEditRules.BackColor = Color.Gold;
            btnEditRules.Font = new Font("Segoe UI", 11F);
            btnEditRules.Location = new Point(348, 451);
            btnEditRules.Name = "btnEditRules";
            btnEditRules.Size = new Size(147, 43);
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
            rulesTextBox.Size = new Size(861, 412);
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
            tabGroceryList.Location = new Point(4, 29);
            tabGroceryList.Margin = new Padding(2);
            tabGroceryList.Name = "tabGroceryList";
            tabGroceryList.Size = new Size(907, 514);
            tabGroceryList.TabIndex = 5;
            tabGroceryList.Text = "Grocery List";
            // 
            // btnClearAllProducts
            // 
            btnClearAllProducts.BackColor = Color.Gold;
            btnClearAllProducts.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClearAllProducts.Location = new Point(440, 443);
            btnClearAllProducts.Margin = new Padding(2);
            btnClearAllProducts.Name = "btnClearAllProducts";
            btnClearAllProducts.Size = new Size(211, 39);
            btnClearAllProducts.TabIndex = 5;
            btnClearAllProducts.Text = "Clear all products";
            btnClearAllProducts.UseVisualStyleBackColor = false;
            btnClearAllProducts.Click += btnClearAllProducts_Click;
            // 
            // btnDeleteSelectedProduct
            // 
            btnDeleteSelectedProduct.BackColor = Color.Gold;
            btnDeleteSelectedProduct.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDeleteSelectedProduct.Location = new Point(173, 445);
            btnDeleteSelectedProduct.Name = "btnDeleteSelectedProduct";
            btnDeleteSelectedProduct.Size = new Size(211, 37);
            btnDeleteSelectedProduct.TabIndex = 4;
            btnDeleteSelectedProduct.Text = "Delete selected product";
            btnDeleteSelectedProduct.UseVisualStyleBackColor = false;
            btnDeleteSelectedProduct.Click += btnClearSelectedProduct_Click;
            // 
            // lbShoppingList
            // 
            lbShoppingList.BackColor = Color.White;
            lbShoppingList.Font = new Font("Segoe UI", 12F);
            lbShoppingList.FormattingEnabled = true;
            lbShoppingList.ItemHeight = 28;
            lbShoppingList.Location = new Point(109, 114);
            lbShoppingList.Name = "lbShoppingList";
            lbShoppingList.Size = new Size(640, 284);
            lbShoppingList.TabIndex = 3;
            // 
            // btnAddToTheList
            // 
            btnAddToTheList.BackColor = Color.Gold;
            btnAddToTheList.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAddToTheList.Location = new Point(542, 44);
            btnAddToTheList.Name = "btnAddToTheList";
            btnAddToTheList.Size = new Size(172, 40);
            btnAddToTheList.TabIndex = 1;
            btnAddToTheList.Text = "Add";
            btnAddToTheList.UseVisualStyleBackColor = false;
            btnAddToTheList.Click += btnAddToTheList_Click;
            // 
            // tbAddGroceries
            // 
            tbAddGroceries.BackColor = Color.White;
            tbAddGroceries.Font = new Font("Segoe UI", 12F);
            tbAddGroceries.Location = new Point(133, 50);
            tbAddGroceries.Name = "tbAddGroceries";
            tbAddGroceries.Size = new Size(384, 34);
            tbAddGroceries.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(927, 562);
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