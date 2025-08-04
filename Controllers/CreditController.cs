using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using play_360.DTOs;
using play_360.Services.Abstration.BusinessLogic;

namespace play_360.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditController : ControllerBase
    {
        private readonly ICreditBusinessLogicService _CreditBusinessLogicService;
        public CreditController(ICreditBusinessLogicService CreditBusinessLogicService) 
        { 
            _CreditBusinessLogicService = CreditBusinessLogicService;
        }

        [HttpGet]
        [Route("GetUserCredits/{userId}")]
        public async Task<ActionResult<DataResponseDTO>> GetUserCredits([FromRoute]int userId)
        {
            var dataResponseDTO = new DataResponseDTO();

            var userCredits = await _CreditBusinessLogicService.GetUserCredits(userId);

            if (userCredits is null)
            {
                dataResponseDTO.Message = "Something went wrong. Could not get user credits";
                dataResponseDTO.Data = null;
                dataResponseDTO.IsSuccessful = false;
                return Ok(dataResponseDTO);
            }

            dataResponseDTO.Message = "User credits";
            dataResponseDTO.Data = userCredits;
            dataResponseDTO.IsSuccessful = true;
            return Ok(dataResponseDTO);
        }
    }
}
