using play_360.EF.Models;
using play_360.Services.Abstration.BusinessLogic;
using play_360.Services.Abstration.DataAccess;

namespace play_360.Services.Concrete.BusinessLogic
{
    public class AcheivementBusinessLogicService : IAcheivementBusinessLogicService 
    {
        private readonly IAcheivementRepository _AcheivementRepository;
        public AcheivementBusinessLogicService(IAcheivementRepository AcheivementRepository) 
        {
            _AcheivementRepository = AcheivementRepository;
        }
        public async Task<IList<UserAchievement>> GetAll()
        {
            var allAcheievemnets = await _AcheivementRepository.GetAll();
            return allAcheievemnets;
        }

    }
}
