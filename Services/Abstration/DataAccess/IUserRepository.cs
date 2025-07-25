using play_360.EF.Models;

namespace play_360.Services.Abstration.DataAccess
{
    public interface IUserRepository
    {
        public Task<User> GetUserByEmail(string Email);
        public Task<int> AddUser(User user);
    }
}
