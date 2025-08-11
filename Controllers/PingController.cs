using Microsoft.AspNetCore.Mvc;
using play_360.DTOs;

namespace play_360.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        [HttpGet]
        [Route("Status")]
        public ActionResult<DataResponseDTO> CheckIfApiIsAlive()
        {
            var dataResponse = new DataResponseDTO();
            dataResponse.Message = "I am alive.";
            dataResponse.Data = new { version = 1.0, lastDeployament = "Deployed Registration."};
            dataResponse.IsSuccessful = true;

            return dataResponse;

        }

    }
}
