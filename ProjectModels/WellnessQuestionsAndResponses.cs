using play_360.EF.Models;

namespace play_360.ProjectModels
{
    public class WellnessQuestionsAndResponses
    {
        public IList<WellnessMultipleChoiceCheckinResponse> WellnessMultipleChoiceCheckinResponses { get; set; } = new List<WellnessMultipleChoiceCheckinResponse>();
        public IList<WellnessScaleQuestionCheckinResponse> WellnessScaleQuestionCheckinResponses { get; set; } = new List<WellnessScaleQuestionCheckinResponse>();
        public IList<WellnessBooleanQuestionCheckinResponse> WellnessBooleanQuestionCheckinResponses { get; set; } = new List<WellnessBooleanQuestionCheckinResponse>();
    }
}
