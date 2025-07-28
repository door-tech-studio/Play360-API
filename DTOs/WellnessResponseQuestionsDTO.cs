using play_360.ProjectModels;

namespace play_360.DTOs
{
    public class WellnessResponseQuestionsDTO
    {
        public int UserId { get; set; }
        public int FeelingType { get; set; }
        public bool IsInjured { get; set; }
        public string Note { get; set; }
        public IList<UserQuestionResponse> UserQuestionResponses { get; set; } = new List<UserQuestionResponse>();
    }
}
