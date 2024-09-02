using FitnessTracker.Entities;

namespace BookStore.Services
{
    public interface IUserProfileService 
    { 
        Task<IEnumerable<UserProfile>> GetAllUsers();
        Task<UserProfile> GetUser(int id);
        Task<string> CreateNewUser(UserProfile user);
        Task<string> UpdateUser(UserProfile user);
        Task<string> DeleteUser(int id);
    }
}
