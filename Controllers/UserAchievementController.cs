using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using play_360.DTOs;
using play_360.EF.Models;
using play_360.Services.Abstration.BusinessLogic;

namespace play_360.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAchievementController : ControllerBase
    {
        private readonly IAcheivementBusinessLogicService _AcheivementBusinessLogicService;

        public UserAchievementController(IAcheivementBusinessLogicService AcheivementBusinessLogicService)
        {
            _AcheivementBusinessLogicService = AcheivementBusinessLogicService;
        }

        [HttpGet]
        [Route("GetAll")]

        public async Task<ActionResult<DataResponseDTO>> GetAll()
        {
            var allAchievements = await _AcheivementBusinessLogicService.GetAll();
            var response = new DataResponseDTO()
            {
                Message = "Got All User Achievements",
                Data = allAchievements,
                IsSuccessful = true
            };
            return Ok(response);
        }
    }
}
