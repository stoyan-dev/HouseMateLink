using System;

namespace HouseMateLink
{
    public class Announcement
    {
        public int AnnouncementID { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public bool IsArchived { get; set; }


        public Announcement(int announcementId,int userId, string description, bool isArchived)
        {
            this.AnnouncementID = announcementId;
            this.UserID = userId;
            this.Description = description;
            this.CreatedAt = DateTime.Today;
            IsArchived = isArchived;
        }
        public Announcement() { }
    }
}