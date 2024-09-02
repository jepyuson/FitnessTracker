namespace FitnessTracker.Entities
{
    public class RunningActivity
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Distance { get; set; } // in km
        public TimeSpan Duration => EndTime - StartTime;
        public double AveragePace => Distance > 0 ? Duration.TotalHours / Distance : 0;

        public int UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
