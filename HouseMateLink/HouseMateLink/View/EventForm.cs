using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using HouseMateLink;
using HouseMateLink.Data;
using Microsoft.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace Copy
{
    public partial class EventForm : Form
    {
       // private string connString = "Server=mssqlstud.fhict.local;Database=dbi545643_dbcalendar;User Id=dbi545643_dbcalendar;Password=12345;TrustServerCertificate=True;";
        private DBHelper dbHelper;
        private UserControlDays userControlDays;

        public EventForm(UserControlDays ucd)
        {
            InitializeComponent();
            dbHelper = new DBHelper();
            userControlDays = ucd;
        }


        private void EventForm_Load(object sender, EventArgs e)
        {
            tbDate.Text = $"{UserControlDays.static_day:D2}/{Calendar.static_month:D2}/{Calendar.static_year}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string eventDate = tbDate.Text;
            string eventText = tbEvent.Text;
            string description = tbDescription.Text;

            if (string.IsNullOrWhiteSpace(eventText))
            {
                MessageBox.Show("Event name can't be empty");
                return;
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Description can't be empty");
                return;
            }

            if (!DateTime.TryParseExact(eventDate, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
            {
                MessageBox.Show("Invalid date format");
                return;
            }

            dbHelper.SaveEvent(parsedDate,eventText, description);
            int day = parsedDate.Day;
            userControlDays.lblEvent.Text = dbHelper.GetEvent(day);
            this.Hide();

        }

        

        public void LoadEventDescription(string description)
        {
            if (!string.IsNullOrEmpty(description))
            {
                lblDescription.Visible = true;
                tbDescription.Visible = true;
                tbDescription.Text = description;

                tbDescription.ReadOnly = true;

                lblEvent.Visible = false;
                tbEvent.Visible = false;
                btnSave.Visible = false;
                lblDate.Visible = false;
                tbDate.Visible = false;

                btnDelete.Visible = true;
            }
            else
            {
                lblDescription.Visible = true;
                tbDescription.Visible = true;
                tbDescription.Text = "";

                tbDescription.ReadOnly = false;

                lblEvent.Visible = true;
                tbEvent.Visible = true;
                btnSave.Visible = true;
                lblDate.Visible = true;
                tbDate.Visible = true;

                btnDelete.Visible = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string eventDate = tbDate.Text;
            dbHelper.ArchiveEvent(eventDate);
            tbDescription.Text = null;
            userControlDays.lblEvent.Text = null;
            this.Hide();

        }

    }
}
