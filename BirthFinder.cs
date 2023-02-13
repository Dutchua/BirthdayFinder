using System;
namespace BirthFinder
{
    class IDValidator
    {

        private Boolean fileExists = File.Exists(Settings.filePath + Settings.fileName);

        public static void Main()
        {
            IDValidator validator = new IDValidator();
            validator.run();
        }

        public void run()
        {
            if(fileExists)
            {
                
            }
        }

        public string[] ReadFile()
        {
            string IDFile = Settings.filePath + Settings.fileName;
            return File.ReadAllLines(IDFile);
        }
    }
}