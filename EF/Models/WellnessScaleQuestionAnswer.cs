namespace play_360.EF.Models
{
    public class WellnessScaleQuestionAnswer
    {

        public int Id { get; set; }
        public int WellnessScaleQuestionId { get; set; }
        public required string AnswerText { get; set; }
        public DateTime CreatedAt { get; set; }

        public WellnessScaleQuestion WellnessScaleQuestion { get; set; }
    }
}
