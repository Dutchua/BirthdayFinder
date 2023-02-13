using System;
using System.Text.RegularExpressions;
namespace BirthFinder
{
    class IDValidator
    {

        private Boolean fileExists = File.Exists(Settings.filePath + Settings.fileName);

        public static void Main()
        {
            IDValidator validator = new IDValidator();
            validator.run();
        }

        public void run()
        {
            if(fileExists)
            {
                string[] fileContents = ReadFile();
                foreach(string line in fileContents)
                {
                    Console.WriteLine();
                }

            }Console.WriteLine("File not found.");
        }

        private Boolean validationChecks(string line)
        {
            return lengthDigitCheck(line) ? (passesLuhnCheck(line) ? true : false) : false;
        }

        private Boolean lengthDigitCheck(string line)
        {
            Regex regex = new Regex(@"^\d{13}$");
            return regex.IsMatch(line);
        }

        private bool passesLuhnCheck(string value)
        {
            long sum = 0;

            for (int i = 0; i < value.Length; i++)
            {
                var digit = value[value.Length - 1 - i] - '0';
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

        public string[] ReadFile()
        {
            string IDFile = Settings.filePath + Settings.fileName;
            return File.ReadAllLines(IDFile);
        }
    }
}