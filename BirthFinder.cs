using System;
namespace BirthFinder
{
    class IDValidator
    {

        private bool fileExists = File.Exists(Settings.filePath + Settings.fileName);
        private ReadWrite rw = new ReadWrite();

        public static void Main()
        {
            IDValidator validator = new IDValidator();
            validator.Run();
        }

        public void Run()
        {
            if(fileExists)
            {                
                string[] fileContents = rw.ReadFile();
                foreach(string line in fileContents)
                {
                    
                }

            }Console.WriteLine("File not found.");
        }
    }
}