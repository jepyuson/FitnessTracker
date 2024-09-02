using FitnessTracker.Entities;

namespace FitnessTracker.Services
{
    public interface IRunningActivityService
    {
        Task<IEnumerable<RunningActivity>> GetAllRunningActivityByUserId(int userId);
        Task<string> CreateRunningActivity(RunningActivity runningActivity);
    }
}
