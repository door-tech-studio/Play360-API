using play_360.Services.Abstration.Domain;

namespace play_360.Services.Concrete.Domain
{
    public class SouthAfricanIdentityValidator : ISouthAfricanIdentityValidator
    {
        public bool IsAfricanIdentityValid(string southAfricanIdNumber)
        {

            if (string.IsNullOrEmpty(southAfricanIdNumber))
            {
                return false;
            }

            if (!CheckIfAllDigits(southAfricanIdNumber))
            {
                return false;
            }

            if (!CheckIfThirteenDigits(southAfricanIdNumber))
            {
                return false;
            }

            if (!IsLuhnAdherent(southAfricanIdNumber))
            {
                return false;
            }

            return true;
        }

        private bool IsLuhnAdherent(string SouthAdricanIdNumber)
        {
            var multipliedByTwoStringedDigit = MultiplySecondDigitBy2(SouthAdricanIdNumber);
            var removedDoubleDigits = CheckForDoubleDigits(multipliedByTwoStringedDigit);
            var summedStringedDigits = SummedStringDigits(removedDoubleDigits);

            if (summedStringedDigits % 10 != 0)
            {
                return false;
            }

            return true;
        }

        private bool CheckIfAllDigits(string southAfricanIdNumber)
        {
            return southAfricanIdNumber.All(Char.IsDigit);
        }

        private bool CheckIfThirteenDigits(string southAfricanIdNumber)
        {
            return southAfricanIdNumber.Length == 13;
        }

        private IList<string> MultiplySecondDigitBy2(string southAfricanIdNumber)
        {
            IList<string> idDigits = new List<string>();

            for (int i = (southAfricanIdNumber.Length - 1); i >= 0; i--)
            {
                var currentChar = southAfricanIdNumber[i];
                var currentCharToInt = int.Parse(currentChar.ToString());
                if ((i + 1)%2 == 0)
                {
                    var multipliedByTwo = currentCharToInt * 2;
                    idDigits.Add(multipliedByTwo.ToString());
                }
                else
                {
                    idDigits.Add(currentCharToInt.ToString());
                }   
            }

            return idDigits.Reverse().ToList();
        }

        private IList<string> CheckForDoubleDigits(IList<string> listOfMultipliedByTwoStringedDigits)
        {
            IList<string> strings = new List<string>();
            foreach (string stringedDigit in listOfMultipliedByTwoStringedDigits)
            {
                var stringedDigitToInt = int.Parse(stringedDigit);
                if (stringedDigitToInt > 9)
                {
                    var intToString = stringedDigitToInt.ToString();
                    var firstDigit = intToString[0].ToString();
                    var secondDigit = intToString[1].ToString();

                    var sumOfTwoDigits = int.Parse(firstDigit) + int.Parse(secondDigit);
                    strings.Add(sumOfTwoDigits.ToString());
                    continue;
                }

                strings.Add(stringedDigit);
            }

            return strings;
        }

        private int SummedStringDigits(IList<string> listOfRemovedDoubleStringedDigits)
        {
            int sumOfAllDigits = 0;
            foreach (string stringedDigit in listOfRemovedDoubleStringedDigits)
            {
                sumOfAllDigits += int.Parse(stringedDigit.ToString());
            }
            return sumOfAllDigits;
        }
    }
}
