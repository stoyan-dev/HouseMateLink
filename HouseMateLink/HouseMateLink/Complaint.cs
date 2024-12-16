namespace HouseMateLink
{
    public class Complaint
    {
        //public int ComplaintID { get; } 
        public DateTime CreatedAt { get; set; } 
        public string Description { get; set; }
        public bool IsArchived {  get; set; }

        //used to save data to the database
        public Complaint(string description, bool isArchived)
        {
            this.Description = description;
            this.CreatedAt = DateTime.Today; 
            this.IsArchived = isArchived;
        }
        //reads and creates objects from database
        public Complaint(string description, DateTime createdAt)
        {
            this.Description = description;
            this.CreatedAt = createdAt;
            this.IsArchived = false;
        }

        //public Complaint() { }
    }
}
