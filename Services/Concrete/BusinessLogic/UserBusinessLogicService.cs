using play_360.EF.Models;
using play_360.Services.Abstration.BusinessLogic;
using play_360.Services.Abstration.DataAccess;
using play_360.Services.Concrete.DataAccess;

namespace play_360.Services.Concrete.BusinessLogic
{
    public class UserBusinessLogicService : IUserBusinessLogicService
    {
        public readonly IUserRepository _UserRepository;
        public UserBusinessLogicService(IUserRepository UserRepository) 
        {
            _UserRepository = UserRepository;
        }

        public async Task<User> GetUserByEmail(string Email)
        {
            return await _UserRepository.GetUserByEmail(Email);
        }

        public async Task<User> GetUserByReferralCode(string referralCode)
        {
            return await _UserRepository.GetUserByReferralCode(referralCode);
        }

        public async Task<User> GetUserById(int Id)
        {
            return await _UserRepository.GetUserById(Id);
        }

        public async Task<int> AddUser(User user)
        {
            var isUserAdded = await _UserRepository.AddUser(user);
            return isUserAdded;
        }

        public async Task<bool> IsUserExist(string userEmail)
        {
            return await _UserRepository.IsUserExist(userEmail);
        }
    }
}
