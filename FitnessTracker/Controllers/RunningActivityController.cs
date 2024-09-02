using BookStore.Services;
using FitnessTracker.Entities;
using FitnessTracker.Services;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RunningActivityController : ControllerBase
    {
        private readonly ILogger<RunningActivityController> _logger;
        private readonly IRunningActivityService _runningActivityService;

        public RunningActivityController(ILogger<RunningActivityController> logger, IRunningActivityService runningActivityService)
        {
            _logger = logger;
            _runningActivityService = runningActivityService;
        }

        [HttpGet]
        public async Task<IEnumerable<RunningActivity>> GetAllRunningActivitiesByUserId(int userId)
        {
            return await _runningActivityService.GetAllRunningActivityByUserId(userId);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRunningActivity(RunningActivity runningActivity)
        {
            var message = await _runningActivityService.CreateRunningActivity(runningActivity);
            return Ok(message);
        }
    }
}
