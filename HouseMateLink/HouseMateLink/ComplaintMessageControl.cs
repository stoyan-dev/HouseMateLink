using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseMateLink
{
    public partial class ComplaintMessageControl : UserControl
    {
        private Label lblComplaintText;
        private Label lblComplaintDate;
        private Button btnArchive;
        private Action<ComplaintMessageControl> onArchiveButtonClick;

        public ComplaintMessageControl(string complaintText, DateTime createdAt, Action<ComplaintMessageControl> onArchiveButtonClick)
        {
            InitializeComponent(); 
            this.onArchiveButtonClick=onArchiveButtonClick;
            InitializeComplaintControl(complaintText, createdAt); 
        }

        private void InitializeComplaintControl(string complaintText, DateTime createdAt)
        {

            this.BackColor = Color.Gold;
            this.Padding = new Padding(10);


            lblComplaintText = new Label
            {
                Text = complaintText, 
                AutoSize = true,        
                Location = new Point(10, 10), 
                Font = new Font("Arial", 10, FontStyle.Regular),  
                ForeColor = Color.Black   
            };

            lblComplaintDate = new Label
            {
                Text = $"Created at: {createdAt.ToShortDateString()}", 
                AutoSize = true,        
                Location = new Point(10, 40),  
                Font = new Font("Arial", 8, FontStyle.Italic),  
                ForeColor = Color.Gray   
            };

            btnArchive = new Button
            {
                Text = "Archive",
                Location = new Point(10, 55),
                Size = new Size(90, 20),
                BackColor = Color.GhostWhite
            };

            btnArchive.Click += BtnArchive_Click;

            this.Controls.Add(lblComplaintText);
            this.Controls.Add(lblComplaintDate);
            this.Controls.Add(btnArchive);

        }

        private void BtnArchive_Click(object sender, EventArgs e)
        {
            onArchiveButtonClick(this);
        }
    }
}
