﻿namespace HouseMateLink
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btnLogIn = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.GhostWhite;
            label1.Location = new Point(72, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(677, 81);
            label1.TabIndex = 0;
            label1.Text = "Student Housing B.V.";
            label1.Click += label1_Click;
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.GhostWhite;
            tbUsername.Location = new Point(419, 149);
            tbUsername.Margin = new Padding(2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(150, 31);
            tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.GhostWhite;
            tbPassword.Location = new Point(419, 232);
            tbPassword.Margin = new Padding(2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(150, 31);
            tbPassword.TabIndex = 2;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.Gold;
            btnLogIn.FlatAppearance.BorderColor = Color.Black;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Times New Roman", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.GhostWhite;
            btnLogIn.Location = new Point(231, 312);
            btnLogIn.Margin = new Padding(2);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(294, 51);
            btnLogIn.TabIndex = 3;
            btnLogIn.Text = "Log in";
            btnLogIn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.GhostWhite;
            label2.Location = new Point(171, 149);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(178, 42);
            label2.TabIndex = 4;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.GhostWhite;
            label3.Location = new Point(184, 228);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 37);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLogIn);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "HouseMateLink";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btnLogIn;
        private Label label2;
        private Label label3;
    }
}
