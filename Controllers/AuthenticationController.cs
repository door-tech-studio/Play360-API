using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using play_360.DTOs;
using play_360.EF.Models;
using play_360.Services.Abstration;
using play_360.Services.Abstration.BusinessLogic;
using play_360.Services.Abstration.Messaging;
using play_360.Services.Concrete.BusinessLogic;

namespace play_360.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IJWTService _IJWTService;
        private readonly IUserBusinessLogicService _UserBusinessLogicService;
        private readonly IEmailMessager _EmailMessager;
        private readonly IReferralBusinessLogicService _ReferralBusinessLogicService;
        public AuthenticationController(
            IJWTService IJWTService,
            IUserBusinessLogicService UserBusinessLogicService,
            IEmailMessager EmailMessager,
            IReferralBusinessLogicService ReferralBusinessLogicService
        ) 
        { 
            _IJWTService = IJWTService;
            _UserBusinessLogicService = UserBusinessLogicService;
            _EmailMessager = EmailMessager;
            _ReferralBusinessLogicService = ReferralBusinessLogicService;
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
        public async Task<ActionResult<DataResponseDTO>> Register([FromBody] RegisterDTO registerDTO)
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

            User? referrerUser = null;
            if (registerDTO.ReferrerCode != null)
            {
                referrerUser = await _UserBusinessLogicService.GetUserByReferralCode(registerDTO.ReferrerCode);
                if (referrerUser == null) 
                {
                    DataResponse.Message = "Reference Code does not exist";
                    DataResponse.Data = null;
                    DataResponse.IsSuccessful = false;
                    return Ok(DataResponse);
                }
            }

            var registeredUser = await _UserBusinessLogicService.AddUser(user);
            if (registeredUser == 0)
            {
                DataResponse.Message = "Could Not Add User.";
                DataResponse.IsSuccessful = false;
                DataResponse.Data = null;
                return Ok(DataResponse);
            }

            var referral = new Referral() 
            { 
                ReffererUserId = referrerUser.Id,
                RefferedUserId = registeredUser,
                ReferralStatusId = 1,
                CreatedAt = DateTime.Now
            };

            var isReferralIserted = await _ReferralBusinessLogicService.Add(referral);

            if (isReferralIserted == 0)
            {
                DataResponse.Message = "Could Not Add Referral.";
                DataResponse.IsSuccessful = false;
                DataResponse.Data = null;
                return Ok(DataResponse);
            }

            DataResponse.Message = "User Added.";
            DataResponse.IsSuccessful = true;
            DataResponse.Data = registeredUser;

            return Ok(DataResponse);
        }
    }
}
