using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMateLink
{
    public class Announcement
    {
 
        private DateTime today;
        private const int duration = 7;
        private AnnouncementType announcementType;
        public string Description { get; set; }


        public Announcement(string description, AnnouncementType announcementType)
        {
            this.Description = description;
            this.announcementType = announcementType;
            today = DateTime.Today;
        }

        public bool isAnnouncementExpired()
        {
            DateTime now = DateTime.Today;
            if (now.Equals(today.AddDays(duration)))
            {
                return true;
            }
            return false;
        }

    }
}