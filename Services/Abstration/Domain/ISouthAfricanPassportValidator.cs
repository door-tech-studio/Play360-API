namespace play_360.Services.Abstration.Domain
{
    public interface ISouthAfricanPassportValidator : IValidator
    {
        public bool IsPassportNumberValid(string SouthAfricanPassportNumber);
    }
}
