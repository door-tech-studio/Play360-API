namespace play_360.EF.Models
{
    public class WellnessBooleanQuestionAnswer
    {
        public int Id { get; set; }
        public int WellnessBooleanQuestionId { get; set; }
        public required string AnswerText { get; set; }
        public WellnessBooleanQuestion WellnessBooleanQuestion { get; set; }
    }
}
