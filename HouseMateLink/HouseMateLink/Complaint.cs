using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseMateLink
{
    public class Complaint
    {
        private const int duration = 7;
        private DateTime today;
        public string Description { get; set; }
        public Complaint(string description)
        {
            this.Description = description;
            today= DateTime.Today;
        }
    }
}
