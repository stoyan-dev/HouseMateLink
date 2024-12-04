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
        private List<User> users;

        public Building()
        {
            users = new List<User>();
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void RemoveUser(User user)
        {
            users.Remove(user);
        }

        public List<User> Tenants()
        {
            List<User> tenants = new List<User>();
            foreach (User user in users)
            {
                if (user.Role.Equals(Role.TENANT))
                {
                    tenants.Add(user);
                }
            }
            return tenants;
        }
    }
}
