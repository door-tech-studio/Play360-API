using Microsoft.EntityFrameworkCore;
using play_360.EF.Contexts;
using play_360.EF.Models;
using play_360.Services.Abstration.DataAccess;
using System;

namespace play_360.Services.Concrete.DataAccess
{
    public class UserRepository : IUserRepository
    {
        private readonly Play360Context _DbContext;
        public UserRepository(Play360Context DbContext)
        {
            _DbContext = DbContext;
        }
        public async Task<User> GetUserByEmail(string Email)
        {
            var user = await _DbContext.Users.Where(user => user.Email == Email).FirstOrDefaultAsync();
            return user!;
        }

        public async Task<User> GetUserByReferralCode(string referralCode)
        {
            var user = await _DbContext.Users.Where(user => user.ReferralCode == referralCode).FirstOrDefaultAsync();
            return user!;
        }

        public async Task<User> GetUserById(int Id)
        {
            var user = await _DbContext.Users.Where(user => user.Id == Id).FirstOrDefaultAsync();
            return user!;
        }

        public async Task<int> AddUser(User user)
        {
            await _DbContext.Users.AddAsync(user);
            await _DbContext.SaveChangesAsync();
            var userId = user.Id;

            return userId;
        }

        public async Task<bool> IsUserExist(string userEmail)
        {
            var user = await _DbContext.Users.Where(user => user.Email == userEmail).FirstOrDefaultAsync();
            if (user == null)
            {
                return false;

            }

            return true;
        }

        public async Task<bool> IsIDNumberExist(string userIDNumber)
        {
            var user = await _DbContext.Users.Where(user => user.IdentityNumber == userIDNumber).FirstOrDefaultAsync();
            if (user == null)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> IsPassportNumberExist(string userPassportNumber)
        {
            var user = await _DbContext.Users.Where(user => user.PassportNumber == userPassportNumber).FirstOrDefaultAsync();
            if (user == null)
            {
                return false;
            }

            return true;
        }
    }
}
