using System;
namespace BirthFinder
{
    class IDValidator
    {

        private bool fileExists = File.Exists(Settings.filePath + Settings.fileName);

        public static void Main()
        {
            IDValidator validator = new IDValidator();
            validator.Run();
        }

        public void Run()
        {
            if(fileExists)
            {
                string[] fileContents = ReadFile();
                foreach(string line in fileContents)
                {
                    
                }

            }Console.WriteLine("File not found.");
        }

        public string[] ReadFile()
        {
            string IDFile = Settings.filePath + Settings.fileName;
            return File.ReadAllLines(IDFile);
        }
    }
}