using play_360.ProjectModels;

namespace play_360.DTOs
{
    public class WellnessQuestionsAndAnswersDTO
    {
        public IList<WellnessMultipleChoiceQuestionsAndAnswers> WellnessMultipleChoiceQuestionsAndAnswers { get; set; } = new List<WellnessMultipleChoiceQuestionsAndAnswers>();
        public IList<WellnessScaleQuestionsAndAnswers> WellnessScaleQuestionsAndAnswers { get; set; } = new List<WellnessScaleQuestionsAndAnswers>();
        public IList<WellnessBooleanQuestionsAndAnswers> WellnessBooleanQuestionsAndAnswers { get; set; } = new List<WellnessBooleanQuestionsAndAnswers>();
    }
}
