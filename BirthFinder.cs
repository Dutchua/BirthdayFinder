using System;
namespace BirthFinder
{
    class FileFinder
    {
        public static void Main()
        {
            string IDFile = Directory.GetCurrentDirectory() + @"\ID.txt";
            string[] lines = File.ReadAllLines(IDFile);
            
        }
    }
}