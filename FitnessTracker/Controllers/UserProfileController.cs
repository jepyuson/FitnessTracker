using BookStore.Services;
using FitnessTracker.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private readonly ILogger<UserProfileController> _logger;
        private readonly IUserProfileService _userProfileService;

        public UserProfileController(ILogger<UserProfileController> logger, IUserProfileService userProfileService)
        {
            _logger = logger;
            _userProfileService = userProfileService;
        }

        [HttpGet]
        public async Task<IEnumerable<UserProfile>> GetAllUsers()
        {
            return await _userProfileService.GetAllUsers();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _userProfileService.GetUser(id);

            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewUser(UserProfile user)
        {
            var message = await _userProfileService.CreateNewUser(user);
            return Ok(message);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(UserProfile user)
        {
            var message = await _userProfileService.UpdateUser(user);
            return Ok(message);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var message = await _userProfileService.DeleteUser(id);
            return Ok(message);
        }
    }
}
