using Microsoft.AspNetCore.Mvc;
using play_360.EF.Models;
using play_360.Services.Abstration.BusinessLogic;
using play_360.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace play_360.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SportTypeController : ControllerBase
    {
        private readonly ISportTypeBusinessLogicService _sportTypeBusinessLogicService;
        public SportTypeController(ISportTypeBusinessLogicService sportTypeBusinessLogicService)
        {
            _sportTypeBusinessLogicService = sportTypeBusinessLogicService;
        }

        [HttpGet("GetAllSportTypes")]
        public async Task<ActionResult<DataResponseDTO>> GetAllSportTypes()
        {
            var dataResponse = new DataResponseDTO();
            var sportTypes = await _sportTypeBusinessLogicService.GetAllSportTypes();
            if (sportTypes is null)
            {
                dataResponse.Message = "No sport types found.";
                dataResponse.Data = null;
                dataResponse.IsSuccessful = false;
                return Ok(dataResponse);
            }
            dataResponse.Message = "Sport types fetched successfully.";
            dataResponse.Data = sportTypes;
            dataResponse.IsSuccessful = true;
            return Ok(dataResponse);
        }

        [HttpPost("AddSportTypeProfile")]
        public async Task<ActionResult<DataResponseDTO>> AddSportTypeProfile([FromBody] List<SportTypeProfileDTO> sportTypeProfile)
        {
            var dataResponse = new DataResponseDTO();
          
            var result = await _sportTypeBusinessLogicService.AddSportTypeProfile(sportTypeProfile);
            if (result is null)
            {
                dataResponse.Message = "Failed to add sport type profiles.";
                dataResponse.Data = null;
                dataResponse.IsSuccessful = false;
                return Ok(dataResponse);
            }
            dataResponse.Message = "Sport type profiles added successfully.";
            dataResponse.Data = result;
            dataResponse.IsSuccessful = true;
            return Ok(dataResponse);
        }

        [HttpGet("GetAllUserSport/{userId}")]
        public async Task<ActionResult<DataResponseDTO>> GetAllUserSport(int userId)
        {
            var dataResponse = new DataResponseDTO();
            var userSport = await _sportTypeBusinessLogicService.GetAllUserSport(userId);
            if (userSport is null)
            {
                dataResponse.Message = "No user sport profile found.";
                dataResponse.Data = null;
                dataResponse.IsSuccessful = false;
                return Ok(dataResponse);
            }
            dataResponse.Message = "User sport profile retrieved successfully.";
            dataResponse.Data = userSport;
            dataResponse.IsSuccessful = true;
            return Ok(dataResponse);
        }
    }
}