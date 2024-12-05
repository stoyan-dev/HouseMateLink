using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;

namespace HouseMateLink
{
    public class Complaint
    {
        public int ComplaintID { get; }
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
            ComplaintID += 1;
            this.Description = description;
            CreatedAt = DateTime.Today;
        }
       
    }
}
