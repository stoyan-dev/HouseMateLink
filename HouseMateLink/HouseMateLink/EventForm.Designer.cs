namespace Copy
{
    partial class EventForm
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
            tbDate = new TextBox();
            tbEvent = new TextBox();
            lblDate = new Label();
            lblEvent = new Label();
            btnSave = new Button();
            tbDescription = new TextBox();
            lblDescription = new Label();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // tbDate
            // 
            tbDate.Enabled = false;
            tbDate.Location = new Point(26, 32);
            tbDate.Name = "tbDate";
            tbDate.Size = new Size(306, 27);
            tbDate.TabIndex = 0;
            // 
            // tbEvent
            // 
            tbEvent.Location = new Point(26, 91);
            tbEvent.Name = "tbEvent";
            tbEvent.Size = new Size(306, 27);
            tbEvent.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(26, 9);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(41, 20);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date";
            // 
            // lblEvent
            // 
            lblEvent.AutoSize = true;
            lblEvent.Location = new Point(26, 68);
            lblEvent.Name = "lblEvent";
            lblEvent.Size = new Size(49, 20);
            lblEvent.TabIndex = 3;
            lblEvent.Text = "Event ";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(131, 246);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(26, 148);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(306, 79);
            tbDescription.TabIndex = 5;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(26, 125);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(26, 246);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 296);
            Controls.Add(btnDelete);
            Controls.Add(lblDescription);
            Controls.Add(tbDescription);
            Controls.Add(btnSave);
            Controls.Add(lblEvent);
            Controls.Add(lblDate);
            Controls.Add(tbEvent);
            Controls.Add(tbDate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EventForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EventForm";
            Load += EventForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDate;
        private TextBox tbEvent;
        private Label lblDate;
        private Label lblEvent;
        private Button btnSave;
        private TextBox tbDescription;
        private Label lblDescription;
        private Button btnDelete;
    }
}