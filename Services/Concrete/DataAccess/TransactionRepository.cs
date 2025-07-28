using play_360.EF.Contexts;
using play_360.EF.Models;
using play_360.Services.Abstration.DataAccess;

namespace play_360.Services.Concrete.DataAccess
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly Play360Context _DbContext;
        public TransactionRepository(Play360Context DbContext) 
        { 
            _DbContext = DbContext;
        }

        public async Task<int> AddTransaction(Transaction transaction)
        {
            await _DbContext.Transactions.AddAsync(transaction);
            var savedflag = await _DbContext.SaveChangesAsync();

            return savedflag;
        }
    }
}
