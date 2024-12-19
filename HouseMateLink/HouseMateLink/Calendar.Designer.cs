namespace HouseMateLink
{
    partial class Calendar
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
            flpDayHolder = new FlowLayoutPanel();
            btnNext = new Button();
            btnPrevious = new Button();
            lblSunday = new Label();
            llblMonday = new Label();
            lblWednesday = new Label();
            lblTuesday = new Label();
            lblFriday = new Label();
            lblThursday = new Label();
            lblSaturday = new Label();
            lblDate = new Label();
            SuspendLayout();
            // 
            // flpDayHolder
            // 
            flpDayHolder.AutoScroll = true;
            flpDayHolder.Location = new Point(12, 111);
            flpDayHolder.Name = "flpDayHolder";
            flpDayHolder.Size = new Size(1191, 717);
            flpDayHolder.TabIndex = 0;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(1084, 19);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(101, 32);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(933, 20);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(101, 32);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // lblSunday
            // 
            lblSunday.AutoSize = true;
            lblSunday.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            lblSunday.Location = new Point(47, 72);
            lblSunday.Name = "lblSunday";
            lblSunday.Size = new Size(84, 26);
            lblSunday.TabIndex = 3;
            lblSunday.Text = "Sunday";
            // 
            // llblMonday
            // 
            llblMonday.AutoSize = true;
            llblMonday.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            llblMonday.Location = new Point(212, 72);
            llblMonday.Name = "llblMonday";
            llblMonday.Size = new Size(90, 26);
            llblMonday.TabIndex = 4;
            llblMonday.Text = "Monday";
            // 
            // lblWednesday
            // 
            lblWednesday.AutoSize = true;
            lblWednesday.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            lblWednesday.Location = new Point(530, 72);
            lblWednesday.Name = "lblWednesday";
            lblWednesday.Size = new Size(123, 26);
            lblWednesday.TabIndex = 6;
            lblWednesday.Text = "Wednesday";
            // 
            // lblTuesday
            // 
            lblTuesday.AutoSize = true;
            lblTuesday.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            lblTuesday.Location = new Point(377, 72);
            lblTuesday.Name = "lblTuesday";
            lblTuesday.Size = new Size(93, 26);
            lblTuesday.TabIndex = 5;
            lblTuesday.Text = "Tuesday";
            // 
            // lblFriday
            // 
            lblFriday.AutoSize = true;
            lblFriday.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            lblFriday.Location = new Point(897, 72);
            lblFriday.Name = "lblFriday";
            lblFriday.Size = new Size(73, 26);
            lblFriday.TabIndex = 8;
            lblFriday.Text = "Friday";
            // 
            // lblThursday
            // 
            lblThursday.AutoSize = true;
            lblThursday.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            lblThursday.Location = new Point(722, 72);
            lblThursday.Name = "lblThursday";
            lblThursday.Size = new Size(103, 26);
            lblThursday.TabIndex = 7;
            lblThursday.Text = "Thursday";
            // 
            // lblSaturday
            // 
            lblSaturday.AutoSize = true;
            lblSaturday.Font = new Font("Yu Gothic", 12F, FontStyle.Bold);
            lblSaturday.Location = new Point(1041, 72);
            lblSaturday.Name = "lblSaturday";
            lblSaturday.Size = new Size(100, 26);
            lblSaturday.TabIndex = 10;
            lblSaturday.Text = "Saturday";
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Yu Gothic", 14F, FontStyle.Bold);
            lblDate.Location = new Point(496, 19);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(354, 35);
            lblDate.TabIndex = 11;
            lblDate.Text = "DATE";
            // 
            // Calendar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1215, 840);
            Controls.Add(btnNext);
            Controls.Add(lblDate);
            Controls.Add(btnPrevious);
            Controls.Add(lblSaturday);
            Controls.Add(lblFriday);
            Controls.Add(lblThursday);
            Controls.Add(lblWednesday);
            Controls.Add(lblTuesday);
            Controls.Add(llblMonday);
            Controls.Add(lblSunday);
            Controls.Add(flpDayHolder);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Calendar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calendar";
            Load += Calendar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpDayHolder;
        private Button btnNext;
        private Button btnPrevious;
        private Label lblSunday;
        private Label llblMonday;
        private Label lblWednesday;
        private Label lblTuesday;
        private Label lblFriday;
        private Label lblThursday;
        private Label lblSaturday;
        private Label lblDate;
    }
}