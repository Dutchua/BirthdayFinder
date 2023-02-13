using System;
namespace BirthFinder
{
    class IDValidator
    {
        public static void Main()
        {
            IDValidator validator = new IDValidator();
            validator.run();
        }

        public void run()
        {
            
        }

        private static string[] ReadFile()
        {
            string IDFile = Settings.filePath + Settings.fileName;
            return File.ReadAllLines(IDFile);
        }
    }
}