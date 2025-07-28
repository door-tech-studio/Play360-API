using play_360.EF.Models;
using play_360.ProjectModels;

namespace play_360.Services.Abstration.DataAccess
{
    public interface IWellnessCheckinQuestionRepository
    {
        public Task<IList<WellnessMultipleChoiceQuestionsAndAnswers>> GetMultipleChoiceQuestionsAndAnswers();
        public Task<IList<WellnessScaleQuestionsAndAnswers>> GetScaleQuestionsAndAnswers();
        public Task<IList<WellnessBooleanQuestionsAndAnswers>> GetBooleanQuestionsAndAnswers();
        public Task<int> AddWellnessCheckin(WellnessCheckin wellnessCheckin);
        public Task AddMultipleChoiceCheckinResponses(IList<WellnessMultipleChoiceCheckinResponse> wellnessMultipleChoiceCheckinResponses);
        public Task AddScaleCheckinResponses(IList<WellnessScaleQuestionCheckinResponse> wellnessScaleCheckinResponses);
        public Task AddBooleanCheckinResponses(IList<WellnessBooleanQuestionCheckinResponse> wellnessBooleanCheckinResponses);
    }
}
