using System;
namespace BirthFinder
{
    class IDValidator
    {

        private bool fileExists = File.Exists(Settings.FilePath + Settings.IDFileName);
        private ReadWrite rw = new ReadWrite();

        public static void Main()
        {
            IDValidator IDvalidator = new IDValidator();
            IDvalidator.Run();
        }

        private void Run()
        {
            if(fileExists)
            {                
                string[] fileContents = rw.ReadFile();
                Validation validation = new Validation();
                foreach(string line in fileContents)
                {
                    if(validation.ValidationChecks(line))
                    {
                        Console.WriteLine("Valid ID: " + line);
                    }
                }

            }Console.WriteLine("File not found.");
        }

        private void ConvertDate(string line)
        {
            try
            {
                int year = int.Parse(line.Substring(0, 2));
                int birthYear;
                if (year >= 0 && year <= 23)
                    birthYear = int.Parse("20" + line.Substring(0, 2));
                else
                    birthYear = int.Parse("19" + line.Substring(0, 2));
            }catch
            {
                Console.WriteLine("Invalid ID Number: " + line);
            }
        }
    }
}