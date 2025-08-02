using Microsoft.EntityFrameworkCore;
using play_360.EF.Contexts;
using play_360.EF.Models;
using play_360.Services.Abstration.DataAccess;

namespace play_360.Services.Concrete.DataAccess
{
    public class ReferralRepositoryService : IReferralRepositoryService
    {
        private readonly Play360Context _Context;
        public ReferralRepositoryService(Play360Context Contex) 
        {
            _Context = Contex;
        }

        public async Task<IList<Referral>> GetReferralsByUserId(int userId)
        {
            var allUserReferrals = await _Context.Referral.Where(referral => referral.ReffererUserId == userId).ToListAsync();
            return allUserReferrals;
        }
        public async Task<int> Add(Referral referral)
        {
            await _Context.Referral.AddAsync(referral);
            var savedflag = await _Context.SaveChangesAsync();
            return savedflag;
        }
    }
}
