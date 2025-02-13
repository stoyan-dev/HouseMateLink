﻿using System;

namespace HouseMateLink
{
    public class Announcement
    {
        public int AnnouncementID { get; set; }
        public string Username { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public bool IsArchived { get; set; }


        public Announcement(string username, string description,bool isArchived)
        {
            this.Username = username;
            this.Description = description;
            this.CreatedAt = DateTime.Today;
            this.IsArchived = isArchived;
        }
        public Announcement(int id,string username, string description, DateTime createdAt)
        {
            this.AnnouncementID = id; 
            this.Username = username;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.IsArchived = false;
        }

        
        //public Announcement() { }
    }
}