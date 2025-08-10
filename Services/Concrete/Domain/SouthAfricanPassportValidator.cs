using play_360.Services.Abstration.Domain;

namespace play_360.Services.Concrete.Domain
{
    public class SouthAfricanPassportValidator : ISouthAfricanPassportValidator
    {
        public bool IsPassportNumberValid(string SouthAfricanPassportNumber)
        {

            var isNineChar = IsNineCharacters(SouthAfricanPassportNumber);
            if (!isNineChar)
            {
                return false;
            }

            var isFirstCharValid = isFirstCharacterValid(SouthAfricanPassportNumber);
            if (!isFirstCharValid)
            {
                return false;
            }

            var isAllDigits = isAllOtherCharactersAllDigits(SouthAfricanPassportNumber);
            if (!isAllDigits)
            {
                return false;
            }

            var isEightDig = isEightDigits(SouthAfricanPassportNumber);
            if (!isEightDig)
            {
                return false;
            }

            return true;
        }

        private bool IsNineCharacters(string SouthAfricanPassportNumber)
        {
            if (SouthAfricanPassportNumber.Length == 9)
            {
                return true;
            }

            return false;
        }

        private bool isFirstCharacterValid(string SouthAfricanPassportNumber)
        {
            var firstCharacter = SouthAfricanPassportNumber[0];

            if (firstCharacter == 'A' || firstCharacter == 'D' || firstCharacter == 'M' || firstCharacter == 'T')
            {
                return true;
            }

            return false;
        }

        private bool isAllOtherCharactersAllDigits(string SouthAfricanPassportNumber)
        {
            var subStringPassportDigits = SouthAfricanPassportNumber.Substring(1);
            return subStringPassportDigits.All(Char.IsDigit);
        }

        private bool isEightDigits(string SouthAfricanPassportNumber)
        {
            var subStringPassportDigits = SouthAfricanPassportNumber.Substring(1);
            return subStringPassportDigits.Length == 8;
        }

    }
}
