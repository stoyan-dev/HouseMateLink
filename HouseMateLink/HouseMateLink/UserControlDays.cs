using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Copy;
using Microsoft.Data.SqlClient;

namespace HouseMateLink
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        private string connString = "Server=mssqlstud.fhict.local;Database=dbi545643_dbcalendar;User Id=dbi545643_dbcalendar;Password=12345;TrustServerCertificate=True;";

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
        }

        public void days(int numDay)
        {
            lblDays.Text = numDay.ToString("D2");
            displayEvent();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lblDays.Text;

            string eventDescription = GetEventDescriptionForDay();

            EventForm eventForm = new EventForm();
            eventForm.LoadEventDescription(eventDescription);
            eventForm.Show();
        }

        private string GetEventDescriptionForDay()
        {
            string description = "";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string sql = "SELECT TOP 1 Description FROM Events WHERE EventDate = @date";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@date",
                            new DateTime(Calendar.static_year, Calendar.static_month, int.Parse(lblDays.Text)));

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                description = reader["Description"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching event description: {ex.Message}");
            }

            return description;
        }



        private void displayEvent()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string sql = "SELECT EventText FROM Events WHERE EventDate = @date";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@date",
                            new DateTime(Calendar.static_year, Calendar.static_month, int.Parse(lblDays.Text)));

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            lblEvent.Text = "";

                            while (reader.Read())
                            {
                                lblEvent.Text += $"{reader["EventText"]}\n";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading events: {ex.Message}");
            }
        }


    }
}