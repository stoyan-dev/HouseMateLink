﻿namespace HouseMateLink
{
    partial class ProfileOverviewTenant
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
            UserInfoSummaryPanel = new Panel();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(393, 23);
            label1.Name = "label1";
            label1.Size = new Size(348, 52);
            label1.TabIndex = 0;
            label1.Text = "Profile Overview";
            // 
            // UserInfoSummaryPanel
            // 
            UserInfoSummaryPanel.Location = new Point(35, 111);
            UserInfoSummaryPanel.Margin = new Padding(2, 2, 2, 2);
            UserInfoSummaryPanel.Name = "UserInfoSummaryPanel";
            UserInfoSummaryPanel.Size = new Size(1027, 570);
            UserInfoSummaryPanel.TabIndex = 1;
            UserInfoSummaryPanel.Paint += UserInfoSummaryPanel_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(46, 42);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(122, 34);
            button1.TabIndex = 2;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ProfileOverviewTenant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1144, 702);
            Controls.Add(button1);
            Controls.Add(UserInfoSummaryPanel);
            Controls.Add(label1);
            Name = "ProfileOverviewTenant";
            Text = "ProfileOverviewTenant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel UserInfoSummaryPanel;
        private Button button1;
    }
}