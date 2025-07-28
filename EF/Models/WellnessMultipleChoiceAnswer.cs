namespace play_360.EF.Models
{
    public class WellnessMultipleChoiceAnswer
    {
        public int Id { get; set; }
        public int WellnessMultipleChoiceQuestionId { get; set; }
        public required string AnswerText { get; set; }

        public WellnessMultipleChoiceQuestion WellnessMultipleChoiceQuestion { get; set; }
    }
}
