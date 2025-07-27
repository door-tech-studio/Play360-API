namespace play_360.EF.Models
{
    public class WellnessQuestion
    {
        public int Id { get; set; }
        public int WellnessResponseId { get; set; }
        public int QuestionTypeId { get; set; }
        public int AgeGroupId { get; set; }
        public string QuestionText { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<WellnessResponse> WellnessResponses { get; } = new List<WellnessResponse>();
    }
}
