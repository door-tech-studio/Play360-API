namespace play_360.EF.Models
{
    public class WellnessCheckin
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FeelingType { get; set; }
        public bool IsInjured { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public User User { get; set; } = null;

        //public ICollection<WellnessResponse> WellnessResponses { get; } = new List<WellnessResponse>();
    }
}
