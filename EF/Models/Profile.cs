using Microsoft.AspNetCore.Mvc;

namespace play_360.EF.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SportTypeId { get; set; }
        public string Position { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public int DominantSideId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public User User { get; set; } = null!;

        public ICollection<ProfileEducation> ProfileEducations = new List<ProfileEducation>();
        public ICollection<ProfileTeam> ProfileTeams = new List<ProfileTeam>();
        public ICollection<ProfileSkill> ProfileSkills = new List<ProfileSkill>();
        public ICollection<ProfileReference> ProfileReferences = new List<ProfileReference>();
        public ICollection<ProfileAchievement> ProfileAchievements = new List<ProfileAchievement>();
        public ICollection<ProfileCertificate> ProfileCertificates = new List<ProfileCertificate>();
        public ICollection<ProfileGoal> ProfileGoals = new List<ProfileGoal>();
        public ICollection<ProfileMedicalInfo> ProfileMedicalInfos = new List<ProfileMedicalInfo>();

    }
}
