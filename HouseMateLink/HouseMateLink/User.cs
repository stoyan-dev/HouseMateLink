using System.Security.Policy;

namespace HouseMateLink
{
    public class User
    {
        public int UserID { get; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }
        public int RoomNumber { get; set; }
        public string Photo { get; set; }
        private int userID = 0;


        public User(string username, string password, string name, Role role, int roomNumber, string photo)
        {
            UserID++;
            Username = username;
            Password = password;
            Name = name;
            Role = role;
            RoomNumber = roomNumber;
            Photo = photo;
        }
    }
}
