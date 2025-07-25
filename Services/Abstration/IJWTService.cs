namespace play_360.Services.Abstration
{
    public interface IJWTService
    {
        public string GenerateToken(string UserName);
    }
}
