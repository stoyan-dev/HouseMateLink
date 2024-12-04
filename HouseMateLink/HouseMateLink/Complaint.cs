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
            today = DateTime.Today;
        }

        public bool iComplaintExpired()
        {
            DateTime now = DateTime.Today;
            if (now.Equals(today.AddDays(duration)))
            {
                return true;
            }
            return false;
        }
    }
}
