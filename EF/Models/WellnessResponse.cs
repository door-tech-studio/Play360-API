namespace play_360.EF.Models
{
    public class WellnessResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        //public int WellnessCheckinId { get; set; }
        public int QuestionId { get; set; }
        public string ResponseValue { get; set; }
        public DateTime CreatedAt { get; set; }
        public User User { get; set; } = null;
        public WellnessQuestion WellnessQuestion { get; set; } = null;
        //public WellnessCheckin WellnessCheckin { get; set; } = null;

    }
}
