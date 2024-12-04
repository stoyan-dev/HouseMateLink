namespace HouseMateLink
{
    partial class RulesForm
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
            rulesTextBox = new TextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // rulesTextBox
            // 
            rulesTextBox.Location = new Point(27, 31);
            rulesTextBox.Multiline = true;
            rulesTextBox.Name = "rulesTextBox";
            rulesTextBox.Size = new Size(746, 333);
            rulesTextBox.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gold;
            btnBack.Location = new Point(586, 383);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(187, 32);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // RulesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(rulesTextBox);
            Name = "RulesForm";
            Text = "Rules";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox rulesTextBox;
        private Button btnBack;
    }
}