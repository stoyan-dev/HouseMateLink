namespace HouseMateLink
{
    public class Complaint
    {
        //public int ComplaintID { get; } 
        public DateTime CreatedAt { get; set; } 
        public string Description { get; set; }
        public bool IsArchived {  get; set; }

        public Complaint(string description, bool isArchived)
        {
            this.Description = description;
            this.CreatedAt = DateTime.Today; 
            this.IsArchived = isArchived;
        }

        public Complaint(string description, DateTime createdAt, bool isArchived)
        {
            this.Description = description;
            this.CreatedAt = createdAt;
            this.IsArchived = isArchived;
        }

        //public Complaint() { }
    }
}
