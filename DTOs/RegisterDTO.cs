namespace play_360.DTOs
{
    public class RegisterDTO
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Bio { get; set; }
        public required string IdentityNumber { get; set; }
        public string? ReferrerCode { get; set; }
    }
}
