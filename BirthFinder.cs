using System;
namespace BirthFinder
{
    class FileFinder
    {
        public static void Main()
        {
            
        }

        private string[] ReadFile()
        {
            string IDFile = Directory.GetCurrentDirectory() + @"\ID.txt";
            return File.ReadAllLines(IDFile);
        }
    }
}