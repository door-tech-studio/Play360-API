namespace play_360.Services.Abstration.Domain
{
    public interface ISouthAfricanIdentityValidator : IValidator
    {
        public bool IsAfricanIdentityValid(string southAdricanIdNumber);
    }
}
