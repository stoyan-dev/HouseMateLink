namespace HouseMateLink
{
    partial class MainForm
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnLogOut = new Button();
            tabCalendar = new TabPage();
            tabAnnouncements = new TabPage();
            tabComplaints = new TabPage();
            tabHouseRules = new TabPage();
            tabShoppingList = new TabPage();
            tabHome.SuspendLayout();
            tabHomePage.SuspendLayout();
            grbButtons.SuspendLayout();
            grbHome.SuspendLayout();
            SuspendLayout();
            // 
            // tabHome
            // 
            tabHome.Controls.Add(tabHomePage);
            tabHome.Controls.Add(tabCalendar);
            tabHome.Controls.Add(tabAnnouncements);
            tabHome.Controls.Add(tabComplaints);
            tabHome.Controls.Add(tabHouseRules);
            tabHome.Controls.Add(tabShoppingList);
            tabHome.Location = new Point(1, 11);
            tabHome.Margin = new Padding(2, 2, 2, 2);
            tabHome.Name = "tabHome";
            tabHome.SelectedIndex = 0;
            tabHome.Size = new Size(628, 396);
            tabHome.TabIndex = 0;
            // 
            // tabHomePage
            // 
            tabHomePage.Controls.Add(grbButtons);
            tabHomePage.Controls.Add(grbHome);
            tabHomePage.Location = new Point(4, 29);
            tabHomePage.Margin = new Padding(2, 2, 2, 2);
            tabHomePage.Name = "tabHomePage";
            tabHomePage.Padding = new Padding(2, 2, 2, 2);
            tabHomePage.Size = new Size(620, 363);
            tabHomePage.TabIndex = 0;
            tabHomePage.Text = "Home Page";
            tabHomePage.UseVisualStyleBackColor = true;
            // 
            // grbButtons
            // 
            grbButtons.Controls.Add(btnProfileOverview);
            grbButtons.Controls.Add(btnGrocery);
            grbButtons.Controls.Add(btnComplaints);
            grbButtons.Controls.Add(btnAnnouncements);
            grbButtons.Controls.Add(btnCalendar);
            grbButtons.Controls.Add(btnRules);
            grbButtons.Location = new Point(234, 22);
            grbButtons.Margin = new Padding(2, 2, 2, 2);
            grbButtons.Name = "grbButtons";
            grbButtons.Padding = new Padding(2, 2, 2, 2);
            grbButtons.Size = new Size(358, 314);
            grbButtons.TabIndex = 3;
            grbButtons.TabStop = false;
            // 
            // btnProfileOverview
            // 
            btnProfileOverview.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProfileOverview.Location = new Point(198, 227);
            btnProfileOverview.Margin = new Padding(2, 2, 2, 2);
            btnProfileOverview.Name = "btnProfileOverview";
            btnProfileOverview.Size = new Size(100, 66);
            btnProfileOverview.TabIndex = 5;
            btnProfileOverview.Text = "Profile Overview";
            btnProfileOverview.UseVisualStyleBackColor = true;
            // 
            // btnGrocery
            // 
            btnGrocery.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGrocery.Location = new Point(29, 227);
            btnGrocery.Margin = new Padding(2, 2, 2, 2);
            btnGrocery.Name = "btnGrocery";
            btnGrocery.Size = new Size(102, 66);
            btnGrocery.TabIndex = 4;
            btnGrocery.Text = "Grocery List";
            btnGrocery.UseVisualStyleBackColor = true;
            // 
            // btnComplaints
            // 
            btnComplaints.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnComplaints.Location = new Point(198, 138);
            btnComplaints.Margin = new Padding(2, 2, 2, 2);
            btnComplaints.Name = "btnComplaints";
            btnComplaints.Size = new Size(107, 65);
            btnComplaints.TabIndex = 3;
            btnComplaints.Text = "Complaints";
            btnComplaints.UseVisualStyleBackColor = true;
            // 
            // btnAnnouncements
            // 
            btnAnnouncements.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAnnouncements.Location = new Point(29, 138);
            btnAnnouncements.Margin = new Padding(2, 2, 2, 2);
            btnAnnouncements.Name = "btnAnnouncements";
            btnAnnouncements.Size = new Size(117, 65);
            btnAnnouncements.TabIndex = 2;
            btnAnnouncements.Text = "Announcements";
            btnAnnouncements.UseVisualStyleBackColor = true;
            // 
            // btnCalendar
            // 
            btnCalendar.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCalendar.Location = new Point(198, 35);
            btnCalendar.Margin = new Padding(2, 2, 2, 2);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(107, 70);
            btnCalendar.TabIndex = 1;
            btnCalendar.Text = "Calendar";
            btnCalendar.UseVisualStyleBackColor = true;
            // 
            // btnRules
            // 
            btnRules.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRules.Location = new Point(29, 35);
            btnRules.Margin = new Padding(2, 2, 2, 2);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(102, 70);
            btnRules.TabIndex = 0;
            btnRules.Text = "House Rules";
            btnRules.UseVisualStyleBackColor = true;
            // 
            // grbHome
            // 
            grbHome.Controls.Add(label3);
            grbHome.Controls.Add(label2);
            grbHome.Controls.Add(label1);
            grbHome.Controls.Add(btnLogOut);
            grbHome.Font = new Font("Times New Roman", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grbHome.Location = new Point(26, 22);
            grbHome.Margin = new Padding(2, 2, 2, 2);
            grbHome.Name = "grbHome";
            grbHome.Padding = new Padding(2, 2, 2, 2);
            grbHome.Size = new Size(185, 314);
            grbHome.TabIndex = 2;
            grbHome.TabStop = false;
            grbHome.Text = "Student Housing B.V.";
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
            btnLogOut.Font = new Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogOut.Location = new Point(27, 253);
            btnLogOut.Margin = new Padding(2, 2, 2, 2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(111, 57);
            btnLogOut.TabIndex = 0;
            btnLogOut.TabStop = false;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // tabCalendar
            // 
            tabCalendar.Location = new Point(4, 29);
            tabCalendar.Margin = new Padding(2, 2, 2, 2);
            tabCalendar.Name = "tabCalendar";
            tabCalendar.Padding = new Padding(2, 2, 2, 2);
            tabCalendar.Size = new Size(620, 363);
            tabCalendar.TabIndex = 1;
            tabCalendar.Text = "Calendar";
            tabCalendar.UseVisualStyleBackColor = true;
            // 
            // tabAnnouncements
            // 
            tabAnnouncements.Location = new Point(4, 29);
            tabAnnouncements.Name = "tabAnnouncements";
            tabAnnouncements.Padding = new Padding(3);
            tabAnnouncements.Size = new Size(620, 363);
            tabAnnouncements.TabIndex = 2;
            tabAnnouncements.Text = "Announcements";
            tabAnnouncements.UseVisualStyleBackColor = true;
            // 
            // tabComplaints
            // 
            tabComplaints.Location = new Point(4, 29);
            tabComplaints.Name = "tabComplaints";
            tabComplaints.Padding = new Padding(3);
            tabComplaints.Size = new Size(620, 363);
            tabComplaints.TabIndex = 3;
            tabComplaints.Text = "Complaints";
            tabComplaints.UseVisualStyleBackColor = true;
            // 
            // tabHouseRules
            // 
            tabHouseRules.Location = new Point(4, 29);
            tabHouseRules.Name = "tabHouseRules";
            tabHouseRules.Padding = new Padding(3);
            tabHouseRules.Size = new Size(620, 363);
            tabHouseRules.TabIndex = 4;
            tabHouseRules.Text = "House Rules";
            tabHouseRules.UseVisualStyleBackColor = true;
            // 
            // tabShoppingList
            // 
            tabShoppingList.Location = new Point(4, 29);
            tabShoppingList.Name = "tabShoppingList";
            tabShoppingList.Padding = new Padding(3);
            tabShoppingList.Size = new Size(620, 363);
            tabShoppingList.TabIndex = 5;
            tabShoppingList.Text = "Shopping list";
            tabShoppingList.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 453);
            Controls.Add(tabHome);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MainForm";
            Text = "HouseMateLink";
            tabHome.ResumeLayout(false);
            tabHomePage.ResumeLayout(false);
            grbButtons.ResumeLayout(false);
            grbHome.ResumeLayout(false);
            grbHome.PerformLayout();
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
        private TabPage tabShoppingList;
    }
}