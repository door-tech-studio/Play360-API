using play_360.EF.Models;
using play_360.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace play_360.Services.Abstration.BusinessLogic
{
    public interface ISportTypeBusinessLogicService
    {
        public Task<IEnumerable<SportTypes>> GetAllSportTypes();
        public Task<List<SportTypeProfileDTO>> AddSportTypeProfile(List<SportTypeProfileDTO> sportTypeProfile);
        public Task<List<UserSportResponseDTO>> GetAllUserSport(int userId);
    }
}