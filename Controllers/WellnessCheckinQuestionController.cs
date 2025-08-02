using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using play_360.DTOs;
using play_360.EF.Models;
using play_360.Services.Abstration.BusinessLogic;
using play_360.Services.Concrete.BusinessLogic;
using System.Reflection;

namespace play_360.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WellnessCheckinQuestionController : ControllerBase
    {
        private readonly IWellnessCheckinQuestionBusinessLogicService _WellnessCheckinQuestionBusinessLogicService;
        private readonly IUserBusinessLogicService _UserBusinessLogicService;

        public WellnessCheckinQuestionController(
            IWellnessCheckinQuestionBusinessLogicService WellnessCheckinQuestionBusinessLogicService,
            IUserBusinessLogicService UserBusinessLogicService
        )
        {
            _WellnessCheckinQuestionBusinessLogicService = WellnessCheckinQuestionBusinessLogicService;
        }

        [HttpGet]
        [Route("GetAllWellnessQuestions")]
        public async Task<ActionResult<DataResponseDTO>> GetAllWellnessQuestions()
        {
            var responseDTO = new DataResponseDTO();
            var wellnessQuestionsAndAnswersDTO = new WellnessQuestionsAndAnswersDTO();

            var allMultipleChoiceQuestionsAndAnswers = await _WellnessCheckinQuestionBusinessLogicService.GetMultipleChoiceQuestionsAndAnswers();
            var allScaleQuestionsAndAnswers = await _WellnessCheckinQuestionBusinessLogicService.GetScaleQuestionsAndAnswers();
            var allBooleanQuestionsAndAnswers = await _WellnessCheckinQuestionBusinessLogicService.GetBooleanQuestionsAndAnswers();
            var allOpenEndedQuestionsAndAnswers = await _WellnessCheckinQuestionBusinessLogicService.GetOpenEndedQuestionsAndAnswers();

            if (
                allMultipleChoiceQuestionsAndAnswers is null || 
                allScaleQuestionsAndAnswers is null  || 
                allBooleanQuestionsAndAnswers is null ||
                allOpenEndedQuestionsAndAnswers is null
            )
            {
                responseDTO.Message = "Wellness questions could not be loaded.";
                responseDTO.Data = null;
                responseDTO.IsSuccessful = false;
                return Ok(responseDTO);
            }

            wellnessQuestionsAndAnswersDTO.WellnessMultipleChoiceQuestionsAndAnswers = allMultipleChoiceQuestionsAndAnswers;
            wellnessQuestionsAndAnswersDTO.WellnessScaleQuestionsAndAnswers = allScaleQuestionsAndAnswers;
            wellnessQuestionsAndAnswersDTO.WellnessBooleanQuestionsAndAnswers = allBooleanQuestionsAndAnswers;
            wellnessQuestionsAndAnswersDTO.WellnessOpenEndedQuestionsAndAnswers = allOpenEndedQuestionsAndAnswers;

            responseDTO.Message = "Wellness Questions";
            responseDTO.Data = wellnessQuestionsAndAnswersDTO;
            responseDTO.IsSuccessful = true;

            return Ok(responseDTO);
        }

        [HttpPost]
        [Route("SaveWellnessCheckinResponse")]
        public async Task<ActionResult<DataResponseDTO>> SaveWellnessCheckinResponse(WellnessResponseQuestionsDTO wellnessResponseQuestionsDTO)
        {
            var responseDTO = new DataResponseDTO();

            var allQuestionResponses = wellnessResponseQuestionsDTO.UserQuestionResponses;

            var multipleChoiceQuestionResponses = new List<WellnessMultipleChoiceCheckinResponse>();
            var scaleQuestionResponses = new List<WellnessScaleQuestionCheckinResponse>();
            var booleanQuestionResponses = new List<WellnessBooleanQuestionCheckinResponse>();
            var openEndedQuestionResponses = new List<WellnessOpenEndedQuestionCheckinResponse>();

            var wellnessCheckin = new WellnessCheckin()
            {
                UserId = wellnessResponseQuestionsDTO.UserId,
                FeelingType = wellnessResponseQuestionsDTO.FeelingType,
                IsInjured = wellnessResponseQuestionsDTO.IsInjured,
                Notes = wellnessResponseQuestionsDTO.Note,
                CreatedAt = DateTime.Now,
            };

            var wellnesssCheckinId = await _WellnessCheckinQuestionBusinessLogicService.AddWellnessCheckin(wellnessCheckin);

            foreach (var questionResponse in  allQuestionResponses)
            {
                var questionType = questionResponse.QuestionType;

                if (questionType == "MultipleChoice")
                {
                    var multipleChoiceQuestionResponse = new WellnessMultipleChoiceCheckinResponse()
                    {
                        UserId = wellnessResponseQuestionsDTO.UserId,
                        WellnessMultipleChoiceQuestionId = questionResponse.QuestionId,
                        WellnessMultipleChoiceAnswerId = (int)questionResponse.Response,
                        WellnessCheckinId = wellnesssCheckinId,
                        CreatedAt = DateTime.Now
                    };

                    multipleChoiceQuestionResponses.Add(multipleChoiceQuestionResponse);
                }

                if (questionType == "Scale")
                {
                    var scaleQuestionResponse = new WellnessScaleQuestionCheckinResponse()
                    {
                        UserId = wellnessResponseQuestionsDTO.UserId,
                        WellnessScaleQuestionId = questionResponse.QuestionId,
                        WellnessScaleAnswerId = (int)questionResponse.Response,
                        WellnessCheckinId = wellnesssCheckinId,
                        CreatedAt = DateTime.Now
                    };

                    scaleQuestionResponses.Add(scaleQuestionResponse);
                }

                if (questionType == "Boolean")
                {
                    var booleanQuestionResponse = new WellnessBooleanQuestionCheckinResponse()
                    {
                        UserId = wellnessResponseQuestionsDTO.UserId,
                        WellnessBooleanQuestionId = questionResponse.QuestionId,
                        WellnessBooleanAnswerId = (int)questionResponse.Response,
                        WellnessCheckinId = wellnesssCheckinId,
                        CreatedAt = DateTime.Now
                    };

                    booleanQuestionResponses.Add(booleanQuestionResponse);
                }

                if (questionType == "OpenEnded")
                {
                    var booleanQuestionResponse = new WellnessOpenEndedQuestionCheckinResponse()
                    {
                        UserId = wellnessResponseQuestionsDTO.UserId,
                        WellnessOpenEndedQuestionId = questionResponse.QuestionId,
                        AnswerText = (string)questionResponse.Response,
                        WellnessCheckinId = wellnesssCheckinId,
                        CreatedAt = DateTime.Now
                    };
                    openEndedQuestionResponses.Add(booleanQuestionResponse);
                }
            }

            await _WellnessCheckinQuestionBusinessLogicService.AddMultipleChoiceCheckinResponses(multipleChoiceQuestionResponses);
            await _WellnessCheckinQuestionBusinessLogicService.AddScaleCheckinResponses(scaleQuestionResponses);
            await _WellnessCheckinQuestionBusinessLogicService.AddBooleanCheckinResponses(booleanQuestionResponses);
            await _WellnessCheckinQuestionBusinessLogicService.AddOpenEndedCheckinResponses(openEndedQuestionResponses);

            return Ok(responseDTO);
        }
    }
}
