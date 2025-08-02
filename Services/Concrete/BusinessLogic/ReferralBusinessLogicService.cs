using play_360.EF.Models;
using play_360.Services.Abstration.BusinessLogic;
using play_360.Services.Abstration.DataAccess;

namespace play_360.Services.Concrete.BusinessLogic
{
    public class ReferralBusinessLogicService : IReferralBusinessLogicService
    {
        private readonly IReferralRepositoryService _ReferralRepositoryService;
        public ReferralBusinessLogicService(IReferralRepositoryService ReferralRepositoryService) 
        { 
            _ReferralRepositoryService = ReferralRepositoryService;
        }

        public async Task<IList<Referral>> GetReferralsByUserId(int userId)
        {
            var userReferrals = await _ReferralRepositoryService.GetReferralsByUserId(userId);
            return userReferrals;
        }
        public async Task<int> Add(Referral referral)
        {
            var saveFlag = await _ReferralRepositoryService.Add(referral);
            return saveFlag;
        }
    }
}
