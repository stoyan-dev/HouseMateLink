using System;

namespace HouseMateLink
{
    public class Announcement
    {
        public int AnnouncementID { get; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }


        public Announcement(int announcementId,string description, DateTime createdAt)
        {
           this.AnnouncementID = announcementId;
            this.Description = description;
            this.CreatedAt = createdAt;
        }
        public Announcement() { }
    }
}