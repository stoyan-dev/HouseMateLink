using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;

namespace HouseMateLink
{
    public class Complaint
    {
        private const int duration = 7;
        private DateTime CreatedAt;
        public string Description { get; set; }
        public bool isExpired
        { get
           {
            return (DateTime.Now - this.CreatedAt).TotalDays > 7;
           }
        }

        public Complaint(string description)
        {
            this.Description = description;
            CreatedAt = DateTime.Today;
        }
       
    }
}
