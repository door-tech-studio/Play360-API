using play_360.EF.Models;

namespace play_360.Services.Abstration.BusinessLogic
{
    public interface ICreditBusinessLogicService
    {
        public Task<int> AddCredit(Credit creditBatch);
        public Task<IList<Credit>> GetUserCredits(int creditId);
    }
}
