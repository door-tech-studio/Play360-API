namespace play_360.EF.Models
{
    public class WellnessScaleQuestionCheckinResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int WellnessCheckinId { get; set; }
        public int WellnessScaleQuestionId { get; set; }
        public int WellnessScaleAnswerId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
