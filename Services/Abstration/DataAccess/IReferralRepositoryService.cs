using play_360.EF.Models;

namespace play_360.Services.Abstration.DataAccess
{
    public interface IReferralRepositoryService
    {
        public Task<IList<Referral>> GetReferralsByUserId(int userId);
        public Task<int> Add(Referral referral);
    }
}
