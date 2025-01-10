using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using HouseMateLink;
using Microsoft.Data.SqlClient;

namespace Copy
{
    public partial class EventForm : Form
    {
       // private string connString = "Server=mssqlstud.fhict.local;Database=dbi545643_dbcalendar;User Id=dbi545643_dbcalendar;Password=12345;TrustServerCertificate=True;";
        private DBHelper dbHelper;

        public EventForm()
        {
            InitializeComponent();
            dbHelper = new DBHelper();
        }

        private void EventForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

            dbHelper.SaveEvent(eventDate,eventText, description);

            this.Close();
            //try
            //{
            //    if (!DateTime.TryParseExact(eventDate, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
            //    {
            //        MessageBox.Show("Invalid date format");
            //        return;
            //    }

            //    using (SqlConnection conn = new SqlConnection(connString))
            //    {
            //        conn.Open();
            //        string sql = "INSERT INTO Events (EventDate, EventText, Description) VALUES (@EventDate, @EventText, @Description)";
            //        using (SqlCommand cmd = new SqlCommand(sql, conn))
            //        {
            //            cmd.Parameters.AddWithValue("@EventDate", parsedDate.ToString("yyyy-MM-dd")); 
            //            cmd.Parameters.AddWithValue("@EventText", eventText);
            //            cmd.Parameters.AddWithValue("@Description", description);

            //            cmd.ExecuteNonQuery();
            //        }
            //    }

            //    MessageBox.Show("Event saved!");
            //    this.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error saving the event: {ex.Message}");
            //}
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
            tbDescription.Text = "";
            this.Close();

            //try
            //{
            //    if (!DateTime.TryParseExact(eventDate, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
            //    {
            //        MessageBox.Show("Invalid date format");
            //        return;
            //    }

            //    using (SqlConnection conn = new SqlConnection(connString))
            //    {
            //        conn.Open();

            //        string checkSql = "SELECT COUNT(*) FROM Events WHERE EventDate = @EventDate";
            //        using (SqlCommand checkCmd = new SqlCommand(checkSql, conn))
            //        {
            //            checkCmd.Parameters.AddWithValue("@EventDate", parsedDate.ToString("yyyy-MM-dd"));

            //            int eventCount = (int)checkCmd.ExecuteScalar();
            //            if (eventCount == 0)
            //            {
            //                MessageBox.Show("No event found for the selected date.");
            //                return;
            //            }
            //        }

            //        DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this event?",
            //                                                    "Delete Event", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //        if (dialogResult == DialogResult.Yes)
            //        {
            //            string deleteSql = "DELETE FROM Events WHERE EventDate = @EventDate";
            //            using (SqlCommand deleteCmd = new SqlCommand(deleteSql, conn))
            //            {
            //                deleteCmd.Parameters.AddWithValue("@EventDate", parsedDate.ToString("yyyy-MM-dd"));
            //                deleteCmd.ExecuteNonQuery();
            //            }

            //            MessageBox.Show("Event deleted successfully!");

            //            tbDescription.Text = "";
            //            this.Close();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error deleting the event: {ex.Message}");
            //}
        }

    }
}
