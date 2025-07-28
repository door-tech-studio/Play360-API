using play_360.EF.Models;

namespace play_360.Services.Abstration.BusinessLogic
{
    public interface IUserBusinessLogicService
    {
        public Task<User> GetUserByEmail(string Email);

        public Task<User> GetUserById(int Id);
        public Task<int> AddUser(User user);

        public Task<bool> IsUserExist(string userEmail);
    }
}
