using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseMateLink
{
    public partial class Calendar : Form
    {
        private int month, year;


        public static int static_month, static_year;

        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void Calendar_Load(object sender, EventArgs e)
        {
            DisplayDays();
        }

        private void DisplayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthname + " " + year;

            static_month = month;
            static_year = year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int daysOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysOfTheWeek; i++)
            {
                userControlBlank ucblank = new userControlBlank();

                flpDayHolder.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();

                ucdays.days(i);
                flpDayHolder.Controls.Add(ucdays);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            flpDayHolder.Controls.Clear();

            month++;


            if (month > 12)
            {
                month = 1;
                year++;
            }

            static_month = month;
            static_year = year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthname + " " + year;

            DateTime now = DateTime.Now;


            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int daysOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysOfTheWeek; i++)
            {
                userControlBlank ucblank = new userControlBlank();

                flpDayHolder.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();

                ucdays.days(i);
                flpDayHolder.Controls.Add(ucdays);
            }

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

            flpDayHolder.Controls.Clear();

            month--;

            if (month < 1)
            {
                month = 12;
                year--;
            }
            static_month = month;
            static_year = year;


            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthname + " " + year;

            DateTime now = DateTime.Now;


            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int daysOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysOfTheWeek; i++)
            {
                userControlBlank ucblank = new userControlBlank();

                flpDayHolder.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();

                ucdays.days(i);
                flpDayHolder.Controls.Add(ucdays);
            }
        }

        private void btnBackToHomePage_Click(object sender, EventArgs e)
        {
            this.Close();

            foreach (Form form in Application.OpenForms)
            {
                if (form is MainForm mainForm)
                {
                    mainForm.Show();
                    break;
                }
            }

            this.Close();
        }
    }
}