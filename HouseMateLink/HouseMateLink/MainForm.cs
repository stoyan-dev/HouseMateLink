using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HouseMateLink
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dateTimePicker.Value = DateTime.Now;
            dateTimePicker.Visible = false;
        }

        private void grbHome_Enter(object sender, EventArgs e)
        {

        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            //RulesForm rulesForm = new RulesForm();
            //rulesForm.ShowDialog();
            tabHome.SelectedIndex = 4;
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            tabHome.SelectedIndex = 1;
        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            tabHome.SelectedIndex = 2;
        }

        private void btnComplaints_Click(object sender, EventArgs e)
        {
            tabHome.SelectedIndex = 3;
        }

        private void btnGrocery_Click(object sender, EventArgs e)
        {
            tabHome.SelectedIndex = 5;
        }

        private void btnProfileOverview_Click(object sender, EventArgs e)
        {

        }

        private void rbEvent_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.Visible = rbEvent.Checked;
           

        }
    }
}
