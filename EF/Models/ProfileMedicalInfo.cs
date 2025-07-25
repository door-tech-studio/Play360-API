namespace play_360.EF.Models
{
    public class ProfileMedicalInfo
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public string MedicalNote { get; set; }
        public string InjuryHistory { get; set; }
        public string DoctorName { get; set; }
        public string DoctorContact { get; set; }
        public string MedicalAidProvider { get; set; }
        public string MedicalAidNumber { get; set; }
        public Profile Profile { get; set; }
    }
}
