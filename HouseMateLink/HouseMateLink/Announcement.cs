using System;

namespace HouseMateLink
{
    public class Announcement
    {
        public int AnnouncementID { get; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }


        public Announcement(string description, DateTime createdAt)
        {
            AnnouncementID++;
            this.Description = description;
            CreatedAt = createdAt;
        }    
    }
}