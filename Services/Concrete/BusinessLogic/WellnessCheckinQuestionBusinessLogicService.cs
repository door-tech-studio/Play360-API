using play_360.EF.Models;
using play_360.ProjectModels;
using play_360.Services.Abstration.BusinessLogic;
using play_360.Services.Abstration.DataAccess;

namespace play_360.Services.Concrete.BusinessLogic
{
    public class WellnessCheckinQuestionBusinessLogicService : IWellnessCheckinQuestionBusinessLogicService
    {
        private readonly IWellnessCheckinQuestionRepository _WellnessCheckinQuestionRepository;
        public WellnessCheckinQuestionBusinessLogicService (IWellnessCheckinQuestionRepository WellnessCheckinQuestionRepository) 
        {
            _WellnessCheckinQuestionRepository = WellnessCheckinQuestionRepository;
        }

        public async Task<IList<WellnessMultipleChoiceQuestionsAndAnswers>> GetMultipleChoiceQuestionsAndAnswers()
        {
            var allMultipleChoiceQuestionsAndAnswers = await _WellnessCheckinQuestionRepository.GetMultipleChoiceQuestionsAndAnswers();
            return allMultipleChoiceQuestionsAndAnswers;
        }

        public async Task<IList<WellnessScaleQuestionsAndAnswers>> GetScaleQuestionsAndAnswers()
        {
            var allScaleQuestionsAndAnswers = await _WellnessCheckinQuestionRepository.GetScaleQuestionsAndAnswers();
            return allScaleQuestionsAndAnswers;
        }

        public async Task<IList<WellnessBooleanQuestionsAndAnswers>> GetBooleanQuestionsAndAnswers()
        {
            var allBooleanQuestionsAndAnswers = await _WellnessCheckinQuestionRepository.GetBooleanQuestionsAndAnswers();
            return allBooleanQuestionsAndAnswers;
        }

        public async Task<int> AddWellnessCheckin(WellnessCheckin wellnessCheckin)
        {
            var wellnessCheckInId = await _WellnessCheckinQuestionRepository.AddWellnessCheckin(wellnessCheckin);
            return wellnessCheckInId;
        }

        public async Task AddMultipleChoiceCheckinResponses(IList<WellnessMultipleChoiceCheckinResponse> wellnessMultipleChoiceCheckinResponses)
        {
            await _WellnessCheckinQuestionRepository.AddMultipleChoiceCheckinResponses(wellnessMultipleChoiceCheckinResponses);
        }
    }
}
