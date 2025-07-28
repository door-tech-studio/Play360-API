namespace play_360.EF.Models
{
    public class WellnessBooleanQuestionCheckinResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int WellnessCheckinId { get; set; }
        public int WellnessBooleanQuestionId { get; set; }
        public int WellnessBooleanAnswerId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
