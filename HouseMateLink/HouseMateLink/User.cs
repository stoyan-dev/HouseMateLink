using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMateLink
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public bool Role { get; set; }
        public int RoomNumber { get; set; }
        public string Photo {  get; set; }

        public User(int userID, string username, string password, string name, bool role, int roomNumber, string photo)
        {
            UserID = userID;
            Username = username;
            Password = password;
            Name = name;
            Role = role;
            RoomNumber = roomNumber;
            Photo = photo;
        }
    }
}
