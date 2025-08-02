namespace play_360.ProjectModels
{
    public class UserQuestionResponse
    {
        public int QuestionId { get; set; }
        public object Response { get; set; }
        public required string QuestionType { get; set; }
    }
}
