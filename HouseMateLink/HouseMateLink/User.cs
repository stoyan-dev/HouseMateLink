using System.Security.Policy;
using System.Text.Json.Serialization;

namespace HouseMateLink
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public Role Role {get; set; }
        public int RoomNumber { get; set; }
        public string Photo { get; set; }
     
        private List<Announcement> announcements;

        //[JsonConstructor ]
        public User(string username, string password, string name, Role role, int roomNumber, string photo)
        {
           this.Username = username;
           this.Password = password;
           this.Name = name;
           this.Role = role;
           this.RoomNumber = roomNumber;
           this.Photo = photo;
           this.announcements = new List<Announcement>();
        }

        public User(string name, Role role, int roomNumber, string photo)
        {
            this.Name = name;
            this.Role = role;
            this.RoomNumber = roomNumber;
            this.Photo = photo;
            this.announcements = new List<Announcement>();
        }
        public User() { }

        public void CreateAnnouncement(string announcementText)
        {
            
            
        }

        public List<Announcement> GetAnnouncements()
        {
            return announcements;
        }
    }
}
