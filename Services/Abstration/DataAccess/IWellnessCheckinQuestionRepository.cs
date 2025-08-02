using play_360.EF.Models;
using play_360.ProjectModels;

namespace play_360.Services.Abstration.DataAccess
{
    public interface IWellnessCheckinQuestionRepository
    {
        public Task<IList<WellnessMultipleChoiceQuestion>> GetMultipleChoiceQuestionsAndAnswers();
        public Task<IList<WellnessScaleQuestion>> GetScaleQuestionsAndAnswers();
        public Task<IList<WellnessBooleanQuestion>> GetBooleanQuestionsAndAnswers();

        public Task<IList<WellnessOpenEndedQuestion>> GetOpenEndedQuestionsAndAnswers();
        public Task<int> AddWellnessCheckin(WellnessCheckin wellnessCheckin);
        public Task AddMultipleChoiceCheckinResponses(IList<WellnessMultipleChoiceCheckinResponse> wellnessMultipleChoiceCheckinResponses);
        public Task AddScaleCheckinResponses(IList<WellnessScaleQuestionCheckinResponse> wellnessScaleCheckinResponses);
        public Task AddBooleanCheckinResponses(IList<WellnessBooleanQuestionCheckinResponse> wellnessBooleanCheckinResponses);
        public Task AddOpenEndedCheckinResponses(IList<WellnessOpenEndedQuestionCheckinResponse> wellnessBooleanCheckinResponses);
    }
}
