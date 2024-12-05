using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace HouseMateLink
{
    public class Building
    {
        public string Name { get; set; }

        private List<User> users;
        private List<Complaint> complaints;
        private List<User> tenants = new List<User>();
        private int taskIndex = 0;

        public Building(string name)
        {
            users = new List<User>();
            complaints = new List<Complaint>();
            this.Name = name;
        }

        public void CreateAddNewUser(string username, string password, string name, Role role, int roomNumber, string photo)
        {
            User newUser = new User(username, password, name, role, roomNumber, photo);
            users.Add(newUser);

            if (newUser.Role == Role.TENANT)
            { tenants.Add(newUser); }
        }

        public void RemoveUser(User user)
        {
            users.Remove(user);
        }

        public List<User> GetUsers()
        {
            return users;
        }

        public List<User> GetTenants()
        {
            return tenants;
        }

        public List<User> AssignWeeklyTasks()
        {
           List<User> assignedTenants = new List<User>();
           int count = tenants.Count;

            for(int i = 0; i < 5; i++)
            {
                assignedTenants.Add(tenants[(taskIndex + i) % count]);
            }
            taskIndex += 5 % count;

            return assignedTenants;
        }


    }
}
