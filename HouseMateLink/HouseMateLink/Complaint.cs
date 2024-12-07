namespace HouseMateLink
{
    public class Complaint
    {
        private static int complaintCounter = 0; 
        public int ComplaintID { get; } 
        private const int Duration = 7; 
        public DateTime CreatedAt { get; set; } 
        public string Description { get; set; } 

        public bool IsExpired
        {
            get
            {
                return (DateTime.Now - this.CreatedAt).TotalDays > Duration;
            }
        }

        public Complaint(string description)
        {
            ComplaintID = ++complaintCounter; 
            this.Description = description;
            this.CreatedAt = DateTime.Today; 
        }
    }
}
