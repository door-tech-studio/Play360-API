using play_360.EF.Models;

namespace play_360.Services.Abstration.BusinessLogic
{
    public interface IReferralBusinessLogicService
    {
        public Task<IList<Referral>> GetReferralsByUserId(int userId);
        public Task<int> Add(Referral referral);
    }
}
