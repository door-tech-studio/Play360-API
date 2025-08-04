using play_360.EF.Models;

namespace play_360.Services.Abstration.DataAccess
{
    public interface ICreditRepository
    {
        public Task<int> AddCredit(Credit creditBatch);
        public Task<IList<Credit>> GetUserCredits(int userId);
    }
}
