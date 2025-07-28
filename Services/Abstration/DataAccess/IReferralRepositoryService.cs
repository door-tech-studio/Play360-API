using play_360.EF.Models;

namespace play_360.Services.Abstration.DataAccess
{
    public interface IReferralRepositoryService
    {
        public Task<int> Add(Referral referral);
    }
}
