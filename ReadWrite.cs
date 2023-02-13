namespace BirthFinder
{
    class ReadWrite
    {
        public string[] ReadFile()
        {
            string IDFile = Settings.filePath + Settings.fileName;
            return File.ReadAllLines(IDFile);
        }

        public void WriteToFIle(string line, int birthYear)
        {
            string DOBPath = @"C:\BBD\C# Fundamentals\BirthdayFinder\docs\DOB.txt";
            if(File.Exists(DOBPath))
            {
                if(birthYear <= 2010)
                {
                    File.AppendAllText(DOBPath, line + " is below 2010 " + Environment.NewLine);
                }else
                {
                    File.AppendAllText(DOBPath, line + " is above 2010" + Environment.NewLine);
                }
            }
        }
    }
}