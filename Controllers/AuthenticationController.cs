using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using play_360.DTOs;
using play_360.EF.Contexts;
using play_360.EF.Models;
using play_360.Services.Abstration;
using play_360.Services.Abstration.BusinessLogic;
using play_360.Services.Abstration.Domain;
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
        private readonly IReferralBusinessLogicService _ReferralBusinessLogicService;
        private readonly ISouthAfricanIdentityValidator _SouthAfricanIdentityValidator;
        private readonly ISouthAfricanPassportValidator _SouthAfricanPassportValidator;
        private readonly Play360Context _Context;
        public AuthenticationController(
            IJWTService IJWTService,
            IUserBusinessLogicService UserBusinessLogicService,
            IEmailMessager EmailMessager,
            IReferralBusinessLogicService ReferralBusinessLogicService,
            ISouthAfricanIdentityValidator SouthAfricanIdentityValidator,
            ISouthAfricanPassportValidator SouthAfricanPassportValidator,
            Play360Context Context
        ) 
        { 
            _IJWTService = IJWTService;
            _UserBusinessLogicService = UserBusinessLogicService;
            _EmailMessager = EmailMessager;
            _ReferralBusinessLogicService = ReferralBusinessLogicService;
            _SouthAfricanIdentityValidator = SouthAfricanIdentityValidator;
            _SouthAfricanPassportValidator = SouthAfricanPassportValidator;
            _Context = Context;
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

            using (var transaction = _Context.Database.BeginTransaction())
            {
                try
                {

                    var emailAlreadyExist = await _UserBusinessLogicService.IsUserExist(registerDTO.Email);
                    if (emailAlreadyExist)
                    {
                        DataResponse.Message = "Something went wrong. Email already exists.";
                        DataResponse.Data = null!;
                        DataResponse.IsSuccessful = false;
                        return Ok(DataResponse);
                    }

                    if (string.IsNullOrEmpty(registerDTO.IdentityNumber) && string.IsNullOrEmpty(registerDTO.PassportNumber))
                    {
                        DataResponse.Message = "Something went wrong. Need atleast PassportNumber or IDNumber.";
                        DataResponse.Data = null!;
                        DataResponse.IsSuccessful = false;
                        return Ok(DataResponse);
                    }

                    if (!string.IsNullOrEmpty(registerDTO.IdentityNumber))
                    {
                        var doesSAIdAlreadyExist = await _UserBusinessLogicService.IsIDNumberExist(registerDTO.IdentityNumber);
                        if (doesSAIdAlreadyExist)
                        {
                            DataResponse.Message = "Something went wrong. SA Identification number already exists.";
                            DataResponse.Data = null!;
                            DataResponse.IsSuccessful = false;
                            return Ok(DataResponse);
                        }

                        if (!_SouthAfricanIdentityValidator.IsAfricanIdentityValid(registerDTO.IdentityNumber!))
                        {
                            DataResponse.Message = "Something went wrong. ID Number is not valid.";
                            DataResponse.Data = null!;
                            DataResponse.IsSuccessful = false;
                            return Ok(DataResponse);
                        }
                    }

                    if (!string.IsNullOrEmpty(registerDTO.PassportNumber))
                    {
                        var doesSAPassportNumberAlreadyExist = await _UserBusinessLogicService.IsPassportNumberExist(registerDTO.PassportNumber);
                        if (doesSAPassportNumberAlreadyExist)
                        {
                            DataResponse.Message = "Something went wrong.Passport number already exists.";
                            DataResponse.Data = null!;
                            DataResponse.IsSuccessful = false;
                            return Ok(DataResponse);
                        }

                        if (!_SouthAfricanPassportValidator.IsPassportNumberValid(registerDTO.PassportNumber!))
                        {
                            DataResponse.Message = "Something went wrong. Passport is not valid.";
                            DataResponse.Data = null;
                            DataResponse.IsSuccessful = false;
                            return Ok(DataResponse);
                        }
                    }

                    User referrerUser = null!;
                    if (registerDTO.ReferrerCode != null)
                    {
                        referrerUser = await _UserBusinessLogicService.GetUserByReferralCode(registerDTO.ReferrerCode);
                        if (referrerUser == null)
                        {
                            DataResponse.Message = "Something went wrong. Reference Code does not exist.";
                            DataResponse.Data = null;
                            DataResponse.IsSuccessful = false;
                            return Ok(DataResponse);
                        }
                    }

                    var randomReferralCodeForRegisteringUser = await GenerateRandomReferralCode();
                    var user = new User()
                    {
                        Email = registerDTO.Email,
                        Password = registerDTO.Password,
                        IsPopiAccepting = false,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        IdentityNumber = registerDTO.IdentityNumber,
                        PassportNumber = registerDTO.PassportNumber,
                        ReferralCode = randomReferralCodeForRegisteringUser,
                        FirstName = registerDTO.FirstName,
                        LastName = registerDTO.LastName
                    };

                    var registeredUser = await _UserBusinessLogicService.AddUser(user);

                    if (registeredUser == 0)
                    {
                        DataResponse.Message = "Something went wrong. Could Not Add User.";
                        DataResponse.IsSuccessful = false;
                        DataResponse.Data = null!;
                        return Ok(DataResponse);
                    }


                    if (referrerUser != null)
                    {
                        var referral = new Referral()
                        {
                            ReffererUserId = referrerUser.Id,
                            RefferedUserId = registeredUser,
                            ReferralStatusId = 1,
                            CreatedAt = DateTime.Now
                        };

                        var isReferralInserted = await _ReferralBusinessLogicService.Add(referral);

                        if (isReferralInserted == 0)
                        {
                            DataResponse.Message = "Something went wrong. Could Not Add Referral.";
                            DataResponse.IsSuccessful = false;
                            DataResponse.Data = null!;
                            return Ok(DataResponse);
                        }
                    }

                    DataResponse.Message = "User Added.";
                    DataResponse.IsSuccessful = true;
                    DataResponse.Data = registeredUser;

                    transaction.Commit();

                    return Ok(DataResponse); 
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    DataResponse.Message = $"Something went wrong: {ex.Message}";
                    DataResponse.Data = null;
                    DataResponse.IsSuccessful = false;
                    return Ok(DataResponse);
                }
            }
            
          
            
        }

        private async Task<string> GenerateRandomReferralCode()
        {
            var randomReferralCode = string.Empty;
            var randomPool = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            var random = new Random();
            
            while (randomReferralCode.Length <= 6)
            {
                var randomNumber = random.Next(0, 52);

                var randomCharacter = randomPool[randomNumber];
                randomReferralCode += randomCharacter;

                if (randomReferralCode.Length == 6)
                {
                    var doesReferralCodeExist = await DoesReferralCodeAlreadyExist(randomReferralCode);
                    if (doesReferralCodeExist)
                    {
                        randomReferralCode = string.Empty;
                    }
                    break;
                }
            }

            return randomReferralCode;
        }

        private async Task<bool> DoesReferralCodeAlreadyExist(string generatedReferralCode)
        {
            var userFromReferralCode = await _UserBusinessLogicService.GetUserByReferralCode(generatedReferralCode);
            if (userFromReferralCode != null) { return true; }

            return false;
        }

        private bool isSAIdValid(string IDNumber)
        {
            return true;
        }

        private bool isSAPassportValid(string IDNumber)
        {
            return true;
        }
    }
}
