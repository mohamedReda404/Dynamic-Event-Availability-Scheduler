namespace Dynamic_Event___Availability_Scheduler.Models
{
    public class Events
    {
        public int EventId { get; set; }
        public string EventDescription { get; set; } = string.Empty;
        public string EventMembers { get; set; }= string.Empty;
        public bool EventApproved { get; set; }
    }
}
