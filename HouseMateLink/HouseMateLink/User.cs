using System.Security.Policy;

namespace HouseMateLink
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }
        public int RoomNumber { get; set; }
        public string Photo { get; set; }
        private int userID = 0;

        private Task tasksUser;
        private List<Announcement> announcementsUser;

        public User(int userID, string username, string password, string name, Role role, int roomNumber, string photo)
        {
            UserID ++;
            Username = username;
            Password = password;
            Name = name;
            Role = role;
            RoomNumber = roomNumber;
            Photo = photo;
            announcementsUser= new List<Announcement>();
        }

        public void AddAnnouncement(Announcement announcement)
        {
            announcementsUser.Add(announcement);
        }
    }
}
