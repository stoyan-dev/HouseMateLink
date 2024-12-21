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
            btnTasks = new Button();
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
            lsbxTasks = new ListBox();
            MyCalendar = new MonthCalendar();
            tabAnnouncements = new TabPage();
            btnHome = new Button();
            grbAnnouncements = new GroupBox();
            btnCreateAnnouncement = new Button();
            tbAnnouncement = new TextBox();
            panelAnnouncements = new Panel();
            tabComplaints = new TabPage();
            btnHomeComplaints = new Button();
            grbComplaints = new GroupBox();
            panelComplaint = new Panel();
            btnPostComplaint = new Button();
            tbCreateComplaint = new TextBox();
            tabHouseRules = new TabPage();
            btnHomeRules = new Button();
            btnEditRules = new Button();
            rulesTextBox = new TextBox();
            tabGroceryList = new TabPage();
            btnHomeGrocery = new Button();
            btnClearAllProducts = new Button();
            btnDeleteSelectedProduct = new Button();
            lbShoppingList = new ListBox();
            btnAddToTheList = new Button();
            tbAddGroceries = new TextBox();
            tabTasks = new TabPage();
            btnHomeTasks = new Button();
            grbTasks = new GroupBox();
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
            tabTasks.SuspendLayout();
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
            tabHome.Controls.Add(tabTasks);
            tabHome.Location = new Point(1, 11);
            tabHome.Margin = new Padding(2);
            tabHome.Name = "tabHome";
            tabHome.SelectedIndex = 0;
            tabHome.Size = new Size(1153, 765);
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
            tabHomePage.Size = new Size(1145, 732);
            tabHomePage.TabIndex = 0;
            tabHomePage.Text = "Home Page";
            tabHomePage.Click += tabHomePage_Click;
            // 
            // grbButtons
            // 
            grbButtons.BackColor = Color.GhostWhite;
            grbButtons.Controls.Add(btnTasks);
            grbButtons.Controls.Add(btnProfileOverview);
            grbButtons.Controls.Add(btnGrocery);
            grbButtons.Controls.Add(btnComplaints);
            grbButtons.Controls.Add(btnAnnouncements);
            grbButtons.Controls.Add(btnCalendar);
            grbButtons.Controls.Add(btnRules);
            grbButtons.Location = new Point(722, 26);
            grbButtons.Margin = new Padding(2);
            grbButtons.Name = "grbButtons";
            grbButtons.Padding = new Padding(2);
            grbButtons.Size = new Size(393, 695);
            grbButtons.TabIndex = 3;
            grbButtons.TabStop = false;
            // 
            // btnTasks
            // 
            btnTasks.BackColor = Color.Gold;
            btnTasks.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnTasks.Location = new Point(14, 600);
            btnTasks.Margin = new Padding(2);
            btnTasks.Name = "btnTasks";
            btnTasks.Size = new Size(365, 77);
            btnTasks.TabIndex = 6;
            btnTasks.Text = "Tasks";
            btnTasks.UseVisualStyleBackColor = false;
            btnTasks.Click += btnTasks_Click;
            // 
            // btnProfileOverview
            // 
            btnProfileOverview.BackColor = Color.Gold;
            btnProfileOverview.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnProfileOverview.Location = new Point(14, 24);
            btnProfileOverview.Margin = new Padding(2);
            btnProfileOverview.Name = "btnProfileOverview";
            btnProfileOverview.Size = new Size(365, 80);
            btnProfileOverview.TabIndex = 5;
            btnProfileOverview.Text = "Profile Overview";
            btnProfileOverview.UseVisualStyleBackColor = false;
            btnProfileOverview.Click += btnProfileOverview_Click;
            // 
            // btnGrocery
            // 
            btnGrocery.BackColor = Color.Gold;
            btnGrocery.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnGrocery.Location = new Point(14, 415);
            btnGrocery.Margin = new Padding(2);
            btnGrocery.Name = "btnGrocery";
            btnGrocery.Size = new Size(365, 77);
            btnGrocery.TabIndex = 4;
            btnGrocery.Text = "Grocery List";
            btnGrocery.UseVisualStyleBackColor = false;
            btnGrocery.Click += btnGrocery_Click;
            // 
            // btnComplaints
            // 
            btnComplaints.BackColor = Color.Gold;
            btnComplaints.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnComplaints.Location = new Point(14, 215);
            btnComplaints.Margin = new Padding(2);
            btnComplaints.Name = "btnComplaints";
            btnComplaints.Size = new Size(365, 80);
            btnComplaints.TabIndex = 3;
            btnComplaints.Text = "Complaints";
            btnComplaints.UseVisualStyleBackColor = false;
            btnComplaints.Click += btnComplaints_Click;
            // 
            // btnAnnouncements
            // 
            btnAnnouncements.BackColor = Color.Gold;
            btnAnnouncements.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnAnnouncements.Location = new Point(14, 315);
            btnAnnouncements.Margin = new Padding(2);
            btnAnnouncements.Name = "btnAnnouncements";
            btnAnnouncements.Size = new Size(365, 80);
            btnAnnouncements.TabIndex = 2;
            btnAnnouncements.Text = "Announcements";
            btnAnnouncements.UseVisualStyleBackColor = false;
            btnAnnouncements.Click += btnAnnouncements_Click;
            // 
            // btnCalendar
            // 
            btnCalendar.BackColor = Color.Gold;
            btnCalendar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnCalendar.Location = new Point(14, 507);
            btnCalendar.Margin = new Padding(2);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(365, 77);
            btnCalendar.TabIndex = 1;
            btnCalendar.Text = "Calendar";
            btnCalendar.UseVisualStyleBackColor = false;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // btnRules
            // 
            btnRules.BackColor = Color.Gold;
            btnRules.FlatAppearance.BorderColor = Color.Black;
            btnRules.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnRules.Location = new Point(14, 120);
            btnRules.Margin = new Padding(2);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(365, 80);
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
            grbHome.Font = new Font("Times New Roman", 16F, FontStyle.Bold | FontStyle.Italic);
            grbHome.Location = new Point(26, 26);
            grbHome.Margin = new Padding(2);
            grbHome.Name = "grbHome";
            grbHome.Padding = new Padding(2);
            grbHome.Size = new Size(674, 695);
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
            gbProfile.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            gbProfile.Location = new Point(17, 39);
            gbProfile.Name = "gbProfile";
            gbProfile.Size = new Size(639, 423);
            gbProfile.TabIndex = 4;
            gbProfile.TabStop = false;
            gbProfile.Text = "Your profile";
            // 
            // lblUserRoom
            // 
            lblUserRoom.AutoSize = true;
            lblUserRoom.Font = new Font("Times New Roman", 14F);
            lblUserRoom.Location = new Point(296, 320);
            lblUserRoom.Name = "lblUserRoom";
            lblUserRoom.Size = new Size(24, 27);
            lblUserRoom.TabIndex = 6;
            lblUserRoom.Text = "..";
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Font = new Font("Times New Roman", 14F);
            lblUserRole.Location = new Point(296, 219);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(24, 27);
            lblUserRole.TabIndex = 5;
            lblUserRole.Text = "..";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Times New Roman", 14F);
            lblUserName.Location = new Point(296, 134);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(24, 27);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "..";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            label4.Location = new Point(296, 176);
            label4.Name = "label4";
            label4.Size = new Size(69, 29);
            label4.TabIndex = 3;
            label4.Text = "Role:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            label5.Location = new Point(296, 276);
            label5.Name = "label5";
            label5.Size = new Size(84, 29);
            label5.TabIndex = 2;
            label5.Text = "Room:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            label6.Location = new Point(296, 96);
            label6.Name = "label6";
            label6.Size = new Size(83, 29);
            label6.TabIndex = 1;
            label6.Text = "Name:";
            // 
            // pbUser
            // 
            pbUser.Location = new Point(17, 70);
            pbUser.Margin = new Padding(2);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(235, 312);
            pbUser.TabIndex = 0;
            pbUser.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            label3.Location = new Point(34, 584);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(175, 30);
            label3.TabIndex = 3;
            label3.Text = "Phone: 0123456789";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            label2.Location = new Point(34, 525);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(198, 59);
            label2.TabIndex = 2;
            label2.Text = "Email: HousingBV@yahoo.com";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(34, 480);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 1;
            label1.Text = "Contact:";
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Gold;
            btnLogOut.Font = new Font("Times New Roman", 15F, FontStyle.Bold | FontStyle.Italic);
            btnLogOut.ForeColor = SystemColors.ActiveCaptionText;
            btnLogOut.Location = new Point(17, 629);
            btnLogOut.Margin = new Padding(2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(155, 48);
            btnLogOut.TabIndex = 0;
            btnLogOut.TabStop = false;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // tabCalendar
            // 
            tabCalendar.BackColor = Color.DeepSkyBlue;
            tabCalendar.Controls.Add(lsbxTasks);
            tabCalendar.Controls.Add(MyCalendar);
            tabCalendar.Location = new Point(4, 29);
            tabCalendar.Margin = new Padding(2);
            tabCalendar.Name = "tabCalendar";
            tabCalendar.Padding = new Padding(2);
            tabCalendar.Size = new Size(1145, 732);
            tabCalendar.TabIndex = 1;
            tabCalendar.Text = "Calendar";
            // 
            // lsbxTasks
            // 
            lsbxTasks.FormattingEnabled = true;
            lsbxTasks.Location = new Point(496, 54);
            lsbxTasks.Margin = new Padding(2);
            lsbxTasks.Name = "lsbxTasks";
            lsbxTasks.Size = new Size(374, 424);
            lsbxTasks.TabIndex = 1;
            // 
            // MyCalendar
            // 
            MyCalendar.BackColor = Color.DeepSkyBlue;
            MyCalendar.Font = new Font("Segoe UI", 12F);
            MyCalendar.Location = new Point(77, 130);
            MyCalendar.Name = "MyCalendar";
            MyCalendar.TabIndex = 0;
            MyCalendar.TrailingForeColor = Color.Gold;
            // 
            // tabAnnouncements
            // 
            tabAnnouncements.BackColor = Color.DeepSkyBlue;
            tabAnnouncements.Controls.Add(btnHome);
            tabAnnouncements.Controls.Add(grbAnnouncements);
            tabAnnouncements.Location = new Point(4, 29);
            tabAnnouncements.Name = "tabAnnouncements";
            tabAnnouncements.Padding = new Padding(3);
            tabAnnouncements.Size = new Size(1145, 732);
            tabAnnouncements.TabIndex = 2;
            tabAnnouncements.Text = "Announcements";
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Gold;
            btnHome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(969, 20);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(159, 43);
            btnHome.TabIndex = 6;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // grbAnnouncements
            // 
            grbAnnouncements.BackColor = Color.DeepSkyBlue;
            grbAnnouncements.Controls.Add(btnCreateAnnouncement);
            grbAnnouncements.Controls.Add(tbAnnouncement);
            grbAnnouncements.Controls.Add(panelAnnouncements);
            grbAnnouncements.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            grbAnnouncements.Location = new Point(7, 70);
            grbAnnouncements.Name = "grbAnnouncements";
            grbAnnouncements.Size = new Size(1121, 649);
            grbAnnouncements.TabIndex = 1;
            grbAnnouncements.TabStop = false;
            grbAnnouncements.Text = "Announcements";
            grbAnnouncements.Enter += grbAnnouncements_Enter;
            // 
            // btnCreateAnnouncement
            // 
            btnCreateAnnouncement.BackColor = Color.Gold;
            btnCreateAnnouncement.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAnnouncement.Location = new Point(917, 585);
            btnCreateAnnouncement.Name = "btnCreateAnnouncement";
            btnCreateAnnouncement.Size = new Size(174, 44);
            btnCreateAnnouncement.TabIndex = 4;
            btnCreateAnnouncement.Text = "Create";
            btnCreateAnnouncement.UseVisualStyleBackColor = false;
            btnCreateAnnouncement.Click += btnCreateAnnouncement_Click;
            // 
            // tbAnnouncement
            // 
            tbAnnouncement.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            tbAnnouncement.Location = new Point(22, 527);
            tbAnnouncement.Multiline = true;
            tbAnnouncement.Name = "tbAnnouncement";
            tbAnnouncement.Size = new Size(871, 102);
            tbAnnouncement.TabIndex = 1;
            // 
            // panelAnnouncements
            // 
            panelAnnouncements.BackColor = Color.DeepSkyBlue;
            panelAnnouncements.Location = new Point(22, 38);
            panelAnnouncements.Name = "panelAnnouncements";
            panelAnnouncements.Size = new Size(1069, 472);
            panelAnnouncements.TabIndex = 5;
            // 
            // tabComplaints
            // 
            tabComplaints.BackColor = Color.DeepSkyBlue;
            tabComplaints.Controls.Add(btnHomeComplaints);
            tabComplaints.Controls.Add(grbComplaints);
            tabComplaints.Location = new Point(4, 29);
            tabComplaints.Name = "tabComplaints";
            tabComplaints.Padding = new Padding(3);
            tabComplaints.Size = new Size(1145, 732);
            tabComplaints.TabIndex = 3;
            tabComplaints.Text = "Complaints";
            // 
            // btnHomeComplaints
            // 
            btnHomeComplaints.BackColor = Color.Gold;
            btnHomeComplaints.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHomeComplaints.Location = new Point(963, 23);
            btnHomeComplaints.Name = "btnHomeComplaints";
            btnHomeComplaints.Size = new Size(159, 43);
            btnHomeComplaints.TabIndex = 7;
            btnHomeComplaints.Text = "Home";
            btnHomeComplaints.UseVisualStyleBackColor = false;
            btnHomeComplaints.Click += btnHomeComplaints_Click;
            // 
            // grbComplaints
            // 
            grbComplaints.BackColor = Color.DeepSkyBlue;
            grbComplaints.Controls.Add(panelComplaint);
            grbComplaints.Controls.Add(btnPostComplaint);
            grbComplaints.Controls.Add(tbCreateComplaint);
            grbComplaints.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            grbComplaints.Location = new Point(7, 72);
            grbComplaints.Name = "grbComplaints";
            grbComplaints.Size = new Size(1121, 647);
            grbComplaints.TabIndex = 0;
            grbComplaints.TabStop = false;
            grbComplaints.Text = "Complaints";
            // 
            // panelComplaint
            // 
            panelComplaint.BackColor = Color.DeepSkyBlue;
            panelComplaint.Location = new Point(19, 47);
            panelComplaint.Margin = new Padding(2);
            panelComplaint.Name = "panelComplaint";
            panelComplaint.Size = new Size(1071, 462);
            panelComplaint.TabIndex = 6;
            // 
            // btnPostComplaint
            // 
            btnPostComplaint.BackColor = Color.Gold;
            btnPostComplaint.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPostComplaint.Location = new Point(922, 584);
            btnPostComplaint.Name = "btnPostComplaint";
            btnPostComplaint.Size = new Size(168, 43);
            btnPostComplaint.TabIndex = 5;
            btnPostComplaint.Text = "Post";
            btnPostComplaint.UseVisualStyleBackColor = false;
            btnPostComplaint.Click += btnPostComplaint_Click;
            // 
            // tbCreateComplaint
            // 
            tbCreateComplaint.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            tbCreateComplaint.Location = new Point(19, 527);
            tbCreateComplaint.Multiline = true;
            tbCreateComplaint.Name = "tbCreateComplaint";
            tbCreateComplaint.Size = new Size(886, 100);
            tbCreateComplaint.TabIndex = 2;
            // 
            // tabHouseRules
            // 
            tabHouseRules.BackColor = Color.DeepSkyBlue;
            tabHouseRules.Controls.Add(btnHomeRules);
            tabHouseRules.Controls.Add(btnEditRules);
            tabHouseRules.Controls.Add(rulesTextBox);
            tabHouseRules.Location = new Point(4, 29);
            tabHouseRules.Margin = new Padding(2);
            tabHouseRules.Name = "tabHouseRules";
            tabHouseRules.Size = new Size(1145, 732);
            tabHouseRules.TabIndex = 4;
            tabHouseRules.Text = "House Rules";
            // 
            // btnHomeRules
            // 
            btnHomeRules.BackColor = Color.Gold;
            btnHomeRules.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHomeRules.Location = new Point(969, 17);
            btnHomeRules.Name = "btnHomeRules";
            btnHomeRules.Size = new Size(159, 43);
            btnHomeRules.TabIndex = 8;
            btnHomeRules.Text = "Home";
            btnHomeRules.UseVisualStyleBackColor = false;
            btnHomeRules.Click += btnHomeRules_Click;
            // 
            // btnEditRules
            // 
            btnEditRules.BackColor = Color.Gold;
            btnEditRules.Font = new Font("Segoe UI", 14F);
            btnEditRules.Location = new Point(439, 662);
            btnEditRules.Name = "btnEditRules";
            btnEditRules.Size = new Size(199, 43);
            btnEditRules.TabIndex = 5;
            btnEditRules.Text = "Edit Rules";
            btnEditRules.UseVisualStyleBackColor = false;
            btnEditRules.Click += btnEditRules_Click;
            // 
            // rulesTextBox
            // 
            rulesTextBox.Font = new Font("Courier New", 13F);
            rulesTextBox.Location = new Point(30, 75);
            rulesTextBox.Multiline = true;
            rulesTextBox.Name = "rulesTextBox";
            rulesTextBox.ScrollBars = ScrollBars.Vertical;
            rulesTextBox.Size = new Size(1064, 566);
            rulesTextBox.TabIndex = 3;
            // 
            // tabGroceryList
            // 
            tabGroceryList.BackColor = Color.DeepSkyBlue;
            tabGroceryList.Controls.Add(btnHomeGrocery);
            tabGroceryList.Controls.Add(btnClearAllProducts);
            tabGroceryList.Controls.Add(btnDeleteSelectedProduct);
            tabGroceryList.Controls.Add(lbShoppingList);
            tabGroceryList.Controls.Add(btnAddToTheList);
            tabGroceryList.Controls.Add(tbAddGroceries);
            tabGroceryList.Location = new Point(4, 29);
            tabGroceryList.Margin = new Padding(2);
            tabGroceryList.Name = "tabGroceryList";
            tabGroceryList.Size = new Size(1145, 732);
            tabGroceryList.TabIndex = 5;
            tabGroceryList.Text = "Grocery List";
            // 
            // btnHomeGrocery
            // 
            btnHomeGrocery.BackColor = Color.Gold;
            btnHomeGrocery.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHomeGrocery.Location = new Point(949, 17);
            btnHomeGrocery.Name = "btnHomeGrocery";
            btnHomeGrocery.Size = new Size(159, 43);
            btnHomeGrocery.TabIndex = 8;
            btnHomeGrocery.Text = "Home";
            btnHomeGrocery.UseVisualStyleBackColor = false;
            btnHomeGrocery.Click += btnHomeGrocery_Click;
            // 
            // btnClearAllProducts
            // 
            btnClearAllProducts.BackColor = Color.Gold;
            btnClearAllProducts.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClearAllProducts.Location = new Point(579, 665);
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
            btnDeleteSelectedProduct.Location = new Point(285, 665);
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
            lbShoppingList.Location = new Point(87, 168);
            lbShoppingList.Name = "lbShoppingList";
            lbShoppingList.Size = new Size(969, 452);
            lbShoppingList.TabIndex = 3;
            // 
            // btnAddToTheList
            // 
            btnAddToTheList.BackColor = Color.Gold;
            btnAddToTheList.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAddToTheList.Location = new Point(673, 97);
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
            tbAddGroceries.Location = new Point(212, 97);
            tbAddGroceries.Name = "tbAddGroceries";
            tbAddGroceries.Size = new Size(384, 34);
            tbAddGroceries.TabIndex = 0;
            // 
            // tabTasks
            // 
            tabTasks.BackColor = Color.DeepSkyBlue;
            tabTasks.Controls.Add(grbTasks);
            tabTasks.Controls.Add(btnHomeTasks);
            tabTasks.Location = new Point(4, 29);
            tabTasks.Name = "tabTasks";
            tabTasks.Size = new Size(1145, 732);
            tabTasks.TabIndex = 6;
            tabTasks.Text = "Tasks";
            // 
            // btnHomeTasks
            // 
            btnHomeTasks.BackColor = Color.Gold;
            btnHomeTasks.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHomeTasks.Location = new Point(945, 20);
            btnHomeTasks.Name = "btnHomeTasks";
            btnHomeTasks.Size = new Size(159, 43);
            btnHomeTasks.TabIndex = 9;
            btnHomeTasks.Text = "Home";
            btnHomeTasks.UseVisualStyleBackColor = false;
            btnHomeTasks.Click += btnHomeTasks_Click;
            // 
            // grbTasks
            // 
            grbTasks.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            grbTasks.Location = new Point(21, 90);
            grbTasks.Name = "grbTasks";
            grbTasks.Size = new Size(1098, 616);
            grbTasks.TabIndex = 10;
            grbTasks.TabStop = false;
            grbTasks.Text = "Tasks";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1145, 771);
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
            tabTasks.ResumeLayout(false);
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
        private MonthCalendar MyCalendar;
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
        private Button btnHome;
        private Button btnHomeComplaints;
        private Button btnHomeRules;
        private Button btnHomeGrocery;
        private ListBox lsbxTasks;
        private TabPage tabTasks;
        private Button btnHomeTasks;
        private Button btnTasks;
        private GroupBox grbTasks;
    }
}