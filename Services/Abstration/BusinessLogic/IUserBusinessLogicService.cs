using play_360.EF.Models;

namespace play_360.Services.Abstration.BusinessLogic
{
    public interface IUserBusinessLogicService
    {
        public Task<User> GetUserByEmail(string Email);
        public Task<int> AddUser(User user);
    }
}
