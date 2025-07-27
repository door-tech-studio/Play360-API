namespace play_360.ProjectModels
{
    public class UserQuestionResponse
    {
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public required string QuestionType { get; set; }
    }
}
