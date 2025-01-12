namespace HouseMateLink
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDays = new Label();
            lblEvent = new Label();
            SuspendLayout();
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Font = new Font("Lucida Sans Typewriter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDays.Location = new Point(12, 13);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(62, 17);
            lblDays.TabIndex = 0;
            lblDays.Text = "label1";
            // 
            // lblEvent
            // 
            lblEvent.Location = new Point(12, 78);
            lblEvent.Name = "lblEvent";
            lblEvent.Size = new Size(133, 25);
            lblEvent.TabIndex = 1;
            lblEvent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            Controls.Add(lblEvent);
            Controls.Add(lblDays);
            Name = "UserControlDays";
            Size = new Size(160, 117);
            Load += UserControlDays_Load;
            Click += UserControlDays_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDays;
        private Label lblEvent;
    }
}
