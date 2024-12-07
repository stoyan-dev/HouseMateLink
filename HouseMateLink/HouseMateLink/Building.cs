using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseMateLink
{
    public class Building
    {
        public string Name { get; set; }

        private List<User> users;
        private List<Complaint> complaints;
        private List<Announcement> announcements;
        private List<User> tenants;
        private int taskIndex = 0;

        public Building(string name)
        {
            users = new List<User>();
            complaints = new List<Complaint>();
            announcements = new List<Announcement>();
            tenants = new List<User>();
            this.Name = name;
        }

        public void CreateAddNewUser(string username, string password, string name, Role role, int roomNumber, string photo)
        {
            User newUser = new User(username, password, name, role, roomNumber, photo);
            users.Add(newUser);

            if (newUser.Role == Role.TENANT)
            {
                tenants.Add(newUser);
            }
        }

        public void RemoveUser(User user)
        {
            users.Remove(user);
            if (user.Role == Role.TENANT)
            {
                tenants.Remove(user);
            }
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

            if (count == 0) return assignedTenants;

            int tasksToAssign = Math.Min(5, count);
            for (int i = 0; i < tasksToAssign; i++)
            {
                assignedTenants.Add(tenants[(taskIndex + i) % count]);
            }

            taskIndex = (taskIndex + tasksToAssign) % count;

            return assignedTenants;
        }

        public void CreateComplaint(string complaintText)
        {
            if (!string.IsNullOrEmpty(complaintText))
            {
                Complaint newComplaint = new Complaint(complaintText);
                complaints.Add(newComplaint);
            }
        }

        public List<Complaint> GetComplaints()
        {
            return complaints;
        }

        
    }
}
