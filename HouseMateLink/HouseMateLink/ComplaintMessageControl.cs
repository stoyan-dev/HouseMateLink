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

        
        public ComplaintMessageControl(string complaintText, DateTime createdAt)
        {
            InitializeComponent();  
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
            this.Controls.Add(lblComplaintText);
            this.Controls.Add(lblComplaintDate);

        }
    }
}
