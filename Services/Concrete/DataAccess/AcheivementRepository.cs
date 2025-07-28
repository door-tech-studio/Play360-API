using Microsoft.EntityFrameworkCore;
using play_360.EF.Contexts;
using play_360.EF.Models;
using play_360.Services.Abstration.DataAccess;

namespace play_360.Services.Concrete.DataAccess
{
    public class AcheivementRepository : IAcheivementRepository
    {
        private readonly Play360Context _Play360Context;
        public AcheivementRepository(Play360Context Play360Context)
        {
            _Play360Context = Play360Context;
        }
        public async Task<IList<UserAchievement>> GetAll()
        {
            var allAcheivments = await _Play360Context.UserAchievement.ToListAsync();

            return allAcheivments;
        }
    }
}
