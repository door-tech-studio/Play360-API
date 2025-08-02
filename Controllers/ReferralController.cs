using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using play_360.DTOs;
using play_360.Services.Abstration.BusinessLogic;

namespace play_360.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReferralController : ControllerBase
    {
        private readonly IReferralBusinessLogicService _ReferralBusinessLogicService;
        public ReferralController(IReferralBusinessLogicService ReferralBusinessLogicService) 
        {
            _ReferralBusinessLogicService = ReferralBusinessLogicService;
        }

        [HttpGet]
        [Route("GetAllReferralsByUserId/{id}")]
        public async Task<ActionResult<DataResponseDTO>> GetAllReferralsByUserId([FromRoute] int id)
        {
            var responseData = new DataResponseDTO();

            var allUserReferrals = await _ReferralBusinessLogicService.GetReferralsByUserId(id);

            if (allUserReferrals is null)
            {
                responseData.Message = "Something went wrong. Could not get user referrals.";
                responseData.Data = null!;
                responseData.IsSuccessful = false;
                return Ok(responseData);
            }

            responseData.Message = "All user referrals.";
            responseData.Data = allUserReferrals;
            responseData.IsSuccessful = true; 
            return Ok(responseData);
        }
    }
}
