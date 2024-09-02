using FitnessTracker.Data;
using FitnessTracker.Entities;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Repositories
{
    public class RunningActivityRepository : IRunningActivityRepository
    {
        private readonly FitnessTrackerDbContext _context;
        public RunningActivityRepository(FitnessTrackerDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateRunningActivity(RunningActivity runningActivity)
        {
            try
            {
                _context.Add(runningActivity);

                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<IEnumerable<RunningActivity>> GetAllRunningActivityByUserId(int userId)
        {
            return await _context.RunningActivities.Where(r => r.UserProfileId == userId).ToListAsync();
        }
    }
}
