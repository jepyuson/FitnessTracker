using AutoMapper;
using FitnessTracker.Entities;
using FitnessTracker.Repositories;
using FitnessTracker.Services;

namespace BookStore.Services
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IUserProfileRepository _userProfileRepository;

        public UserProfileService(IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }

        public async Task<string> CreateNewUser(UserProfile user)
        {

            var created = await _userProfileRepository.CreateNewUser(user);

            return created ? $"Created new Author: {user.Name}" : $"Failed to create new user";
        }

        public async Task<string> DeleteUser(int id)
        {
            if (id < 1)
                return "Invalid Id";

            var deleted = await _userProfileRepository.DeleteUserr(id);

            return deleted ? $"Successfully deleted User" : $"Failed to delete User Id: {id}";
        }

        public async Task<IEnumerable<UserProfile>> GetAllUsers()
        {
            return await _userProfileRepository.GetAllUsers();
        }

        public async Task<UserProfile> GetUser(int id)
        {
            return await _userProfileRepository.GetUser(id) ?? null;
        }

        public async Task<string> UpdateUser(UserProfile user)
        {
            if (user == null || user.Id <= 0)
                return "Invalid parameters";

            var updated = await _userProfileRepository.UpdateUser(user);

            return updated ? $"Successfully updated User: {user.Name}" : $"Failed to update User: {user.Name}";
        }
    }
}
