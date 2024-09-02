using FitnessTracker.Entities;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Data
{
    public class FitnessTrackerDbContext : DbContext
    {
        public FitnessTrackerDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<RunningActivity> RunningActivities { get; set; }
    }
}
