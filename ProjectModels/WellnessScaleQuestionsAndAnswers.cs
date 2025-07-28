using play_360.EF.Models;

namespace play_360.ProjectModels
{
    public class WellnessScaleQuestionsAndAnswers
    {
        public WellnessScaleQuestion WellnessScaleQuestion { get; set; }
        public IList<WellnessScaleQuestionAnswer> WellnessScaleQuestionAnswers { get; set; } = new List<WellnessScaleQuestionAnswer>();
    }
}
