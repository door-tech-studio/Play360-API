using play_360.EF.Models;

namespace play_360.Services.Abstration.BusinessLogic
{
    public interface IReferralBusinessLogicService
    {
        public Task<int> Add(Referral referral);
    }
}
