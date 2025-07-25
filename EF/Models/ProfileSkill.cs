namespace play_360.EF.Models
{
    public class ProfileSkill
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public int SkillName { get; set; }
        public int ProficiencyLevelId { get; set; }
        public Profile Profile { get; set; }
    }
}
