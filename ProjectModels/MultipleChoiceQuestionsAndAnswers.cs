using play_360.EF.Models;

namespace play_360.ProjectModels
{
    public class WellnessMultipleChoiceQuestionsAndAnswers
    {
        public WellnessMultipleChoiceQuestion MultipleChoiceQuestion { get; set; }
        public IList<WellnessMultipleChoiceAnswer> WellnessMultipleChoiceAnswers { get; set; } = new List<WellnessMultipleChoiceAnswer>();
    }
}
