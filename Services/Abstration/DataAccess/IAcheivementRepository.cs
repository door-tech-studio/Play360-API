using play_360.EF.Models;

namespace play_360.Services.Abstration.DataAccess
{
    public interface IAcheivementRepository
    {
        public Task<IList<UserAchievement>> GetAll();
    }
}
