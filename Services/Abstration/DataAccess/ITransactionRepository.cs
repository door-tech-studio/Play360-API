using play_360.EF.Models;

namespace play_360.Services.Abstration.DataAccess
{
    public interface ITransactionRepository
    {
        public Task<int> AddTransaction(Transaction transaction);
    }
}
