using System;
namespace BirthFinder
{
    class IDValidator
    {

        private static bool fileExists = File.Exists(Settings.FilePath + Settings.IDFileName);
        private ReadWrite rw = new ReadWrite();

        public static void Main()
        {
            if(fileExists)
            {                
            IDValidator IDvalidator = new IDValidator();
            IDvalidator.Run();
            }else
            {
                Console.WriteLine("File not found.");
            }
        }

        private void Run()
        {
            string[] fileContents = rw.ReadFile();
            Validation validation = new Validation();
            foreach(string line in fileContents)
            {
                if(validation.ValidationChecks(line))
                {
                    Console.WriteLine("Valid ID: " + line);
                }else
                {
                    Console.WriteLine("Invalid ID Number: " + line);
                }
            }
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

                rw.WriteToFIle(line, birthYear);
            }catch
            {
                Console.WriteLine("Invalid ID Number: " + line);
            }
        }
    }
}