using play_360.EF.Models;

namespace play_360.ProjectModels
{
    public class WellnessBooleanQuestionsAndAnswers
    {
        public WellnessBooleanQuestion WellnessBooleanQuestion { get; set; }
        public IList<WellnessBooleanQuestionAnswer> WellnessBooleanQuestionAnswers { get; set; } = new List<WellnessBooleanQuestionAnswer>();
    }
}
