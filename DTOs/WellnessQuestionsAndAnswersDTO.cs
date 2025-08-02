using play_360.EF.Models;
using play_360.ProjectModels;

namespace play_360.DTOs
{
    public class WellnessQuestionsAndAnswersDTO
    {
        public IList<WellnessMultipleChoiceQuestion> WellnessMultipleChoiceQuestionsAndAnswers { get; set; } = new List<WellnessMultipleChoiceQuestion>();
        public IList<WellnessScaleQuestion> WellnessScaleQuestionsAndAnswers { get; set; } = new List<WellnessScaleQuestion>();
        public IList<WellnessBooleanQuestion> WellnessBooleanQuestionsAndAnswers { get; set; } = new List<WellnessBooleanQuestion>();
        public IList<WellnessOpenEndedQuestion> WellnessOpenEndedQuestionsAndAnswers { get; set; } = new List<WellnessOpenEndedQuestion>();
    }
}
