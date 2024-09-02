using FitnessTracker.Entities;

namespace FitnessTracker.Repositories
{
    public interface IUserProfileRepository
    {
        Task<IEnumerable<UserProfile>> GetAllUsers();
        Task<UserProfile> GetUser(int id);
        Task<bool> CreateNewUser(UserProfile user);
        Task<bool> UpdateUser(UserProfile user);
        Task<bool> DeleteUserr(int id);
    }
}
