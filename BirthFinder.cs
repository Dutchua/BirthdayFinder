using System;
namespace BirthFinder
{
    class IDValidator : Settings
    {
        public static void Main()
        {
            
        }

        private static string[] ReadFile()
        {
            string IDFile = Settings.filePath + Settings.fileName;
            return File.ReadAllLines(IDFile);
        }
    }
}