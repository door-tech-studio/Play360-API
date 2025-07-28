using play_360.EF.Models;

namespace play_360.Services.Abstration.DataAccess
{
    public interface IUserRepository
    {
        public Task<User> GetUserByEmail(string Email);
        public Task<User> GetUserByReferralCode(string referralCode);
        public Task<int> AddUser(User user);
        public Task<User> GetUserById(int Id);
        public Task<bool> IsUserExist(string userEmail);
    }
}
