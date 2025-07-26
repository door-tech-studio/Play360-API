using play_360.EF.Models;
using play_360.Services.Abstration.BusinessLogic;
using play_360.Services.Abstration.DataAccess;
using play_360.Services.Concrete.DataAccess;

namespace play_360.Services.Concrete.BusinessLogic
{
    public class CreditBusinessLogicService : ICreditBusinessLogicService
    {
        private readonly ICreditRepository _CreditRepository;
        public CreditBusinessLogicService(ICreditRepository CreditRepository) 
        { 
            _CreditRepository = CreditRepository;
        }

        public async Task<int> AddCredit(Credit creditBatch)
        {
            var isCreditBatchAdded = await _CreditRepository.AddCredit(creditBatch);
            return isCreditBatchAdded;
        }
    }
}
