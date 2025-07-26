using play_360.EF.Contexts;
using play_360.EF.Models;
using play_360.Services.Abstration.DataAccess;

namespace play_360.Services.Concrete.DataAccess
{
    public class CreditRepository : ICreditRepository
    {
        private readonly Play360Context _DbContext;
        public CreditRepository(Play360Context DbContext)
        {
            _DbContext = DbContext;
        }

        public async Task<int> AddCredit(Credit creditBatch)
        {
            await _DbContext.Credits.AddAsync(creditBatch);
            var savedflag = await _DbContext.SaveChangesAsync();

            return savedflag;
        }
    }
}
