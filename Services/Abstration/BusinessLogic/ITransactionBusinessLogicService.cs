using play_360.EF.Models;

namespace play_360.Services.Abstration.BusinessLogic
{
    public interface ITransactionBusinessLogicService
    {
        public Task<int> AddTransaction(Transaction transaction);
    }
}
