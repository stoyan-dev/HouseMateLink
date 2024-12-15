﻿using System;

namespace HouseMateLink
{
    public class Announcement
    {
        public int AnnouncementID { get; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public bool IsArchived { get; set; }


        public Announcement(int announcementId,string description, DateTime createdAt, bool isArchived)
        {
            this.AnnouncementID = announcementId;
            this.Description = description;
            this.CreatedAt = createdAt;
            IsArchived = isArchived;
        }
        public Announcement() { }
    }
}