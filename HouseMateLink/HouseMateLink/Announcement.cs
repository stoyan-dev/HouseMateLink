using System;

namespace HouseMateLink
{
    public class Announcement
    {
        private static int announcementCounter = 0;
        public int AnnouncementID { get; }
        public DateTime CreatedAt { get; set; }
        private const int duration = 7;  
        public string Description { get; set; }

        public bool IsExpired
        {
            get
            {
                return (DateTime.Now - this.CreatedAt).TotalDays > duration;
            }
        }

        public Announcement(string description, DateTime createdAt)
        {
            AnnouncementID = ++announcementCounter;
            this.Description = description;
            CreatedAt = DateTime.Today;
        }

        public Announcement(string description) : this(description, DateTime.Today)
        {
        }
    }
}