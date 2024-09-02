using FitnessTracker.Entities;

namespace FitnessTracker.Repositories
{
    public interface IRunningActivityRepository
    {
        Task<IEnumerable<RunningActivity>> GetAllRunningActivityByUserId(int userId);
        Task<bool> CreateRunningActivity(RunningActivity runningActivity);
    }
}
