using AutoMapper;
using FitnessTracker.Entities;
using FitnessTracker.Repositories;

namespace FitnessTracker.Services
{
    public class RunningActivityService : IRunningActivityService
    {
        private readonly IRunningActivityRepository _runningActivityRepository;

        public RunningActivityService(IRunningActivityRepository runningActivityRepository)
        {
            _runningActivityRepository = runningActivityRepository;
        }
        public async Task<string> CreateRunningActivity(RunningActivity runningActivity)
        {

            var created = await _runningActivityRepository.CreateRunningActivity(runningActivity);

            return created ? $"Created new activity for: {runningActivity.UserProfile.Name}" : $"Failed to create new activity";
        }

        public async Task<IEnumerable<RunningActivity>> GetAllRunningActivityByUserId(int userId)
        {
            return await _runningActivityRepository.GetAllRunningActivityByUserId(userId);
        }
    }
}
