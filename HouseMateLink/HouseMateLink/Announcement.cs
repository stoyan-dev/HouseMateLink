using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMateLink
{
    public class Announcement
    {
        public int AnnouncementID { get; }
        private DateTime CreatedAt;
        private const int duration = 7;
        private AnnouncementType announcementType;
        public string Description { get; set; }
        public bool isExpired
        {
            get
            {
                return (DateTime.Now - this.CreatedAt).TotalDays > 7;
            }
        }
        public bool IsEvent {  get; set; }
        public DateTime EventDate
        {
            get
            {
                if (!IsEvent)
                {
                    throw new InvalidOperationException("EventDate is only available when IsEvent is true.");
                }
                return this.EventDate;
            }
            set
            {
                if (!IsEvent)
                {
                    throw new InvalidOperationException("Cannot set EventDate when IsEvent is false.");
                }
            }
        }

        public Announcement(string description, AnnouncementType announcementType, bool IsEvent)
        {
            AnnouncementID += 1;
            this.Description = description;
            this.announcementType = announcementType;
            CreatedAt = DateTime.Today;
        }

    }
}