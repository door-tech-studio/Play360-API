using play_360.DTOs;
using play_360.EF.Models;
using play_360.Services.Abstration.BusinessLogic;
using play_360.Services.Abstration.DataAccess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace play_360.Services.Concrete.BusinessLogic
{
    public class SportTypeBusinessLogicService : ISportTypeBusinessLogicService
    {
        private readonly ISportTypeRepository _sportTypeRepository;
        public SportTypeBusinessLogicService(ISportTypeRepository sportTypeRepository)
        {
            _sportTypeRepository = sportTypeRepository;
        }

        public async Task<IEnumerable<SportTypes>> GetAllSportTypes()
        {
            return await _sportTypeRepository.GetAllSportTypes();
        }

        public async Task<List<SportTypeProfileDTO>> AddSportTypeProfile(List<SportTypeProfileDTO> sportTypeProfile)
        {
            return  await _sportTypeRepository.AddSportTypeProfile(sportTypeProfile);   
        }

        public async Task<List<UserSportResponseDTO>> GetAllUserSport(int userId)
        {
            return await _sportTypeRepository.GetAllUserSport(userId);
        }
    }
}