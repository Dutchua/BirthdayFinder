using System.Text.RegularExpressions;
namespace BirthFinder
{
    class Validation
    {
        public delegate bool Validate(string line);

        public bool ValidationChecks(string line)
        {    
            Validate lengthDigitCheck = LengthDigitCheck;
            Validate luhnCheck = LuhnCheck;
            return lengthDigitCheck(line) ? (luhnCheck(line) ? true : false) : false;
        }

        private bool LengthDigitCheck(string line)
        {
            Regex regex = new Regex(@"^\d{13}$");
            return regex.IsMatch(line);
        }

        private bool LuhnCheck(string line)
        {
            long sum = 0;

            for (int i = 0; i < line.Length; i++)
            {
                var digit = line[line.Length - 1 - i] - '0';
                sum += (i % 2 != 0) ? GetDouble(digit) : digit;
            }

            return sum % 10 == 0;

            int GetDouble(long i)
            {
                switch (i)
                {
                    case 0: return 0;
                    case 1: return 2;
                    case 2: return 4;
                    case 3: return 6;
                    case 4: return 8;
                    case 5: return 1;
                    case 6: return 3;
                    case 7: return 5;
                    case 8: return 7;
                    case 9: return 9;
                    default: return 0;
                }
            }
        }
    }
}