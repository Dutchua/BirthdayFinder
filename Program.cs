using System;

namespace GetBirthdate
{
    class BirthdateFromID
    {
        public static void Main()
        {
            string IDFile = @"C:\BBD\C# Fundamentals\GetDOB\ID.txt";


                if (File.Exists(IDFile)) 
                {
                string[] lines = File.ReadAllLines(IDFile);

                foreach(string line in lines)
                {
                    if (line.Length != 13)
                    {
                        Console.WriteLine("ID Error: " + line);
                        continue;
                    }

                    int year = int.Parse(line.Substring(0, 2));
                    int birthYear;
                    if (year >= 0 && year <= 23)
                        birthYear = int.Parse("20" + line.Substring(0, 2));
                    else
                        birthYear = int.Parse("19" + line.Substring(0, 2));

                    if (birthYear < 1930 || birthYear > 2023)
                    {
                        Console.WriteLine("ID Error: " + line);
                        continue;
                    }

                    Console.WriteLine(line.Substring(4, 2) + "/" +  line.Substring(2, 2) + "/" + birthYear);
                }
            }
        }
    }
}