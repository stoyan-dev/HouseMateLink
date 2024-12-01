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
            HomePage = new Panel();
            grbHome = new GroupBox();
            btnLogOut = new Button();
            btnRules = new Button();
            btnCalendar = new Button();
            btnAnnouncements = new Button();
            btnComplaints = new Button();
            btnGrocery = new Button();
            btnProfileOverview = new Button();
            grbButtons = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            HomePage.SuspendLayout();
            grbHome.SuspendLayout();
            grbButtons.SuspendLayout();
            SuspendLayout();
            // 
            // HomePage
            // 
            HomePage.Controls.Add(grbButtons);
            HomePage.Controls.Add(grbHome);
            HomePage.Location = new Point(12, 12);
            HomePage.Name = "HomePage";
            HomePage.Size = new Size(761, 426);
            HomePage.TabIndex = 0;
            // 
            // grbHome
            // 
            grbHome.Controls.Add(label3);
            grbHome.Controls.Add(label2);
            grbHome.Controls.Add(label1);
            grbHome.Controls.Add(btnLogOut);
            grbHome.Font = new Font("Times New Roman", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            grbHome.Location = new Point(18, 18);
            grbHome.Name = "grbHome";
            grbHome.Size = new Size(231, 393);
            grbHome.TabIndex = 0;
            grbHome.TabStop = false;
            grbHome.Text = "Student Housing B.V.";
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogOut.Location = new Point(34, 316);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(139, 71);
            btnLogOut.TabIndex = 0;
            btnLogOut.TabStop = false;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnRules
            // 
            btnRules.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRules.Location = new Point(36, 44);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(128, 88);
            btnRules.TabIndex = 0;
            btnRules.Text = "House Rules";
            btnRules.UseVisualStyleBackColor = true;
            // 
            // btnCalendar
            // 
            btnCalendar.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCalendar.Location = new Point(248, 44);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(134, 88);
            btnCalendar.TabIndex = 1;
            btnCalendar.Text = "Calendar";
            btnCalendar.UseVisualStyleBackColor = true;
            // 
            // btnAnnouncements
            // 
            btnAnnouncements.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAnnouncements.Location = new Point(36, 172);
            btnAnnouncements.Name = "btnAnnouncements";
            btnAnnouncements.Size = new Size(146, 81);
            btnAnnouncements.TabIndex = 2;
            btnAnnouncements.Text = "Announcements";
            btnAnnouncements.UseVisualStyleBackColor = true;
            // 
            // btnComplaints
            // 
            btnComplaints.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnComplaints.Location = new Point(248, 172);
            btnComplaints.Name = "btnComplaints";
            btnComplaints.Size = new Size(134, 81);
            btnComplaints.TabIndex = 3;
            btnComplaints.Text = "Complaints";
            btnComplaints.UseVisualStyleBackColor = true;
            // 
            // btnGrocery
            // 
            btnGrocery.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGrocery.Location = new Point(36, 284);
            btnGrocery.Name = "btnGrocery";
            btnGrocery.Size = new Size(128, 83);
            btnGrocery.TabIndex = 4;
            btnGrocery.Text = "Grocery List";
            btnGrocery.UseVisualStyleBackColor = true;
            // 
            // btnProfileOverview
            // 
            btnProfileOverview.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProfileOverview.Location = new Point(248, 284);
            btnProfileOverview.Name = "btnProfileOverview";
            btnProfileOverview.Size = new Size(125, 83);
            btnProfileOverview.TabIndex = 5;
            btnProfileOverview.Text = "Profile Overview";
            btnProfileOverview.UseVisualStyleBackColor = true;
            // 
            // grbButtons
            // 
            grbButtons.Controls.Add(btnProfileOverview);
            grbButtons.Controls.Add(btnGrocery);
            grbButtons.Controls.Add(btnComplaints);
            grbButtons.Controls.Add(btnAnnouncements);
            grbButtons.Controls.Add(btnCalendar);
            grbButtons.Controls.Add(btnRules);
            grbButtons.Location = new Point(284, 18);
            grbButtons.Name = "grbButtons";
            grbButtons.Size = new Size(448, 393);
            grbButtons.TabIndex = 1;
            grbButtons.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 172);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 1;
            label1.Text = "Contact:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 202);
            label2.Name = "label2";
            label2.Size = new Size(219, 53);
            label2.TabIndex = 2;
            label2.Text = "Email: stoyandev@yahoo.com";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 260);
            label3.Name = "label3";
            label3.Size = new Size(219, 38);
            label3.TabIndex = 3;
            label3.Text = "Phone: 0123456789";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HomePage);
            Name = "MainForm";
            Text = "HouseMateLink";
            HomePage.ResumeLayout(false);
            grbHome.ResumeLayout(false);
            grbHome.PerformLayout();
            grbButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel HomePage;
        private GroupBox grbHome;
        private Button btnLogOut;
        private GroupBox grbButtons;
        private Button btnProfileOverview;
        private Button btnGrocery;
        private Button btnComplaints;
        private Button btnAnnouncements;
        private Button btnCalendar;
        private Button btnRules;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}