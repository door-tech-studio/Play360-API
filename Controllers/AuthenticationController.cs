using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using play_360.DTOs;
using play_360.EF.Models;
using play_360.Services.Abstration;
using play_360.Services.Abstration.BusinessLogic;
using play_360.Services.Abstration.Messaging;

namespace play_360.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IJWTService _IJWTService;
        private readonly IUserBusinessLogicService _UserBusinessLogicService;
        private readonly IEmailMessager _EmailMessager;
        public AuthenticationController(
            IJWTService IJWTService,
            IUserBusinessLogicService UserBusinessLogicService,
            IEmailMessager EmailMessager
        ) 
        { 
            _IJWTService = IJWTService;
            _UserBusinessLogicService = UserBusinessLogicService;
            _EmailMessager = EmailMessager;
        }

        [AllowAnonymous]        
        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<DataResponseDTO>> Login(LoginDTO loginDTO)
        {

            var responseData = new DataResponseDTO();
            var token = _IJWTService.GenerateToken(loginDTO.Email);

            if (token == null)
            {
                responseData.Message = "Could not generate token";
                responseData.Data = null;
                return NotFound(responseData);
            }

            User user = await _UserBusinessLogicService.GetUserByEmail(loginDTO.Email);

            if (user == null)
            {
                responseData.Message = "Could not login. User Not found.";
                responseData.Data = null;
                responseData.IsSuccessful = false;
                return Ok(responseData);
            }

            var loginResponse = new LoginResponseDTO
            {
                Email = loginDTO.Email,
                UserId = user.Id,
                Token = token
            };

            responseData.Message = "User Found";
            responseData.Data = loginResponse;
            responseData.IsSuccessful = true;

            return Ok(responseData);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("ConfirmationEmail")]
        public ActionResult<DataResponseDTO> ConfirmationEmail([FromBody] ConfirmationEmailDTO confirmationEmailDTO)
        {
            _EmailMessager.SendEmail(confirmationEmailDTO.Email, "OTP Confirmation", $"This is your OTP: {confirmationEmailDTO.OTP}");

            var dataResponse = new DataResponseDTO() { 
                Message = "Email Sent", 
                Data = null, 
                IsSuccessful = true
            };

            return Ok(dataResponse);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult<DataResponseDTO>> Register(RegisterDTO registerDTO)
        {
            var DataResponse = new DataResponseDTO();
            var user = new User()
            {
                Email = registerDTO.Email,
                Password = registerDTO.Password,
                IsPopiAccepting = false,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };

            var isUserExist = await _UserBusinessLogicService.IsUserExist(registerDTO.Email);
            if (isUserExist) 
            {
                DataResponse.Message = "User already exists";
                DataResponse.Data = null;
                DataResponse.IsSuccessful = false;
                return Ok(DataResponse);
            }

            var isUserAdded = await _UserBusinessLogicService.AddUser(user);
            if (isUserAdded == 0)
            {
                DataResponse.Message = "Could Not Add User.";
                DataResponse.IsSuccessful = false;
                DataResponse.Data = isUserAdded;
                return Ok(DataResponse);
            }

            DataResponse.Message = "User Added.";
            DataResponse.IsSuccessful = true;
            DataResponse.Data = isUserAdded;

            return Ok(DataResponse);
        }
    }
}
