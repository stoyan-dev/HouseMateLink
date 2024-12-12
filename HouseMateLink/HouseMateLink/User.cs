using System.Security.Policy;

namespace HouseMateLink
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public Role Role {get; set; }
        public int RoomNumber { get; set; }
        public string Photo { get; set; }
     
        private List<Announcement> announcements;

        public User(string username, string password, string name, Role role, int roomNumber, string photo)
        {
            UserID++;
            Username = username;
            Password = password;
            Name = name;
            Role = role;
            RoomNumber = roomNumber;
            Photo = photo;
            announcements = new List<Announcement>();
        }

        public void CreateAnnouncement(string announcementText)
        {
            if (!string.IsNullOrEmpty(announcementText))
            {
                Announcement newAnnouncement = new Announcement(announcementText, DateTime.Today);
                announcements.Add(newAnnouncement);
            }
        }

        public List<Announcement> GetAnnouncements()
        {
            return announcements;
        }
    }
}
