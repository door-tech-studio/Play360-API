using play_360.EF.Models;
using play_360.Services.Abstration.BusinessLogic;
using play_360.Services.Abstration.DataAccess;

namespace play_360.Services.Concrete.BusinessLogic
{
    public class TransactionBusinessLogicService : ITransactionBusinessLogicService
    {
        private readonly ITransactionRepository _TransactionRepository;
        public TransactionBusinessLogicService(ITransactionRepository TransactionRepository) 
        {
            _TransactionRepository = TransactionRepository;
        }

        public async Task<int> AddTransaction(Transaction transaction)
        {
            var isTransactionAdded = await _TransactionRepository.AddTransaction(transaction);
            return isTransactionAdded;
        }
    }
}
