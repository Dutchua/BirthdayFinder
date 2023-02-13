using System;
namespace BirthFinder
{
    class IDValidator
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