using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace HouseMateLink
{
    public class Building
    {
        public string Name { get; set; }
        public int amountOfRooms { get; set; }

        private List<User> users;
        private List<Complaint> complaints;
        private List<Announcement> announcements;
        private List<User> tenants;
        private int taskIndex = 0;

        public Building(string name, int amountOfRooms)
        {
            users = new List<User>();
            complaints = new List<Complaint>();
            announcements = new List<Announcement>();
            tenants = new List<User>();
            this.Name = name;
            this.amountOfRooms = 6;
            
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
           
        }

        public List<Complaint> GetComplaints()
        {
            return complaints;
        }

        public string LoadHouseRules()
        {
            string defaultRules = $"House Rules:{Environment.NewLine}{Environment.NewLine}" +
                                 $"1. Respect each other's space.{Environment.NewLine}" +
                                 $"2. Always clean up after yourself in shared spaces like the kitchen, living room, and bathroom.{Environment.NewLine}" +
                                 $"3. Maintain silence between 10 PM and 8 AM on weekdays to ensure everyone can study or rest.{Environment.NewLine}" +
                                 $"4. Follow the rotating schedule for shared chores like taking out the trash and cleaning common areas.{Environment.NewLine}" +
                                 $"5. Turn off lights, water taps, and electronics when not in use to save energy and reduce bills.{Environment.NewLine}" +
                                 $"6. The use of illegal drugs or substances is strictly prohibited within the housing premises.{Environment.NewLine}" +
                                 $"7. Smoking is prohibited inside the building. Use designated smoking areas outside.{Environment.NewLine}" +
                                 $"8. Guests must respect the house rules and not disturb others.";
            return defaultRules;
        }
        
        public User ValidateUser(string username, string password, bool isAdmin)
        {
            User newUser = null;
            try
            {
                using SqlConnection connection = new SqlConnection("Server=mssqlstud.fhict.local;Database=dbi550238;User Id=dbi550238;Password=12345;");
                string sql = "SELECT * FROM Users where Username = @Username AND Password = @Password";
                using SqlCommand command = new SqlCommand(sql,connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("Password", password);

                using SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    newUser = new User
                    {
                        Username = reader.GetString(1),
                        Password = reader.GetString(2),
                        Name = reader.GetString(3),
                        Role = (Role)Enum.Parse(typeof(Role), reader.GetString(4)),
                        RoomNumber = reader.GetInt32(5),
                        Photo=reader.GetString(6)
                    };
                }
                isAdmin = newUser.Role == Role.ADMIN;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return newUser;
        }
    }
}