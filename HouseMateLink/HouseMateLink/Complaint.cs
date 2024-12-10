namespace HouseMateLink
{
    public class Complaint
    {
        public int ComplaintID { get; } 
        public DateTime CreatedAt { get; set; } 
        public string Description { get; set; } 

       

        public Complaint(string description)
        {
            ComplaintID ++; 
            this.Description = description;
            this.CreatedAt = DateTime.Today; 
        }
    }
}
