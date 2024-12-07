namespace HouseMateLink
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(491, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(421, 65);
            label1.TabIndex = 0;
            label1.Text = "Profile Overview";
            // 
            // UserInfoSummaryPanel
            // 
            UserInfoSummaryPanel.Location = new Point(44, 139);
            UserInfoSummaryPanel.Name = "UserInfoSummaryPanel";
            UserInfoSummaryPanel.Size = new Size(1284, 713);
            UserInfoSummaryPanel.TabIndex = 1;
            // 
            // ProfileOverviewTenant
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1430, 878);
            Controls.Add(UserInfoSummaryPanel);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ProfileOverviewTenant";
            Text = "ProfileOverviewTenant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel UserInfoSummaryPanel;
    }
}