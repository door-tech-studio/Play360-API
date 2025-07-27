namespace play_360.EF.Models
{
    public class WellnessMultipleChoiceQuestion
    {
        public int Id { get; set; }
        public int AgeGroupId { get; set; }
        public int FrequencyTypeId { get; set; }
        public int QuestionCategoryId { get; set; }
        public required string QuestionText { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<WellnessMultipleChoiceAnswer> WellnessMultipleChoiceAnswers { get; set; } = new List<WellnessMultipleChoiceAnswer>();
    }
}
