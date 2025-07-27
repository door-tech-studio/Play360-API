namespace play_360.EF.Models
{
    public class WellnessMultipleChoiceCheckinResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int WellnessCheckinId { get; set; }
        public int WellnessMultipleChoiceQuestionId { get; set; }
        public int WellnessMultipleChoiceAnswerId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
