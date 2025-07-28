using play_360.EF.Models;

namespace play_360.Services.Abstration.BusinessLogic
{
    public interface IAcheivementBusinessLogicService
    {
        public Task<IList<UserAchievement>> GetAll();

    }
}
