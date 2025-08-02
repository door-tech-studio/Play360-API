namespace play_360.EF.Models
{
    public class WellnessOpenEndedQuestionCheckinResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int WellnessOpenEndedQuestionId { get; set; }
        public int WellnessCheckinId { get; set; }
        public required string AnswerText { get; set; }
        public DateTime CreatedAt { get; set; }
        public WellnessOpenEndedQuestion WellnessOpenEndedQuestion { get; set; }
    }
}
