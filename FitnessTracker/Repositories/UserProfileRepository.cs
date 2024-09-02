
using FitnessTracker.Data;
using FitnessTracker.Entities;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Repositories
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly FitnessTrackerDbContext _context;

        public UserProfileRepository(FitnessTrackerDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateNewUser(UserProfile user)
        {
            try
            {
                _context.Add(user);

                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeleteUserr(int id)
        {
            var user = await _context.UserProfiles.FindAsync(id);

            if (user != null)
            {
                _context.UserProfiles.Remove(user);
                await _context.SaveChangesAsync();

                return true;
            }
            return false;
        }

        public async Task<IEnumerable<UserProfile>> GetAllUsers()
        {
            return await _context.UserProfiles.ToListAsync();
        }

        public async Task<UserProfile> GetUser(int id)
        {
            return await _context.UserProfiles.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<bool> UpdateUser(UserProfile user)
        {
            var userToUpdate = await _context.UserProfiles.FindAsync(user.Id);

            if (userToUpdate != null)
            {
                userToUpdate.Name = user.Name;
                userToUpdate.Weight = user.Weight;
                userToUpdate.Height = user.Height;
                userToUpdate.BirthDate = user.BirthDate;

                await _context.SaveChangesAsync();

                return true;
            }

            return false;
        }
    }
}
