namespace Dynamic_Event___Availability_Scheduler.Models
{
    public class TimeTables
    {
        public int TimeTableID { get; set; }
        public DayOfWeek Day {  get; set; }

        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
