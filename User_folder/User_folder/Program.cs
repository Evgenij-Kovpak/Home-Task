using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace User_folder
{
     
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"C:\Users\evgen");
            ShowAllFoldersUnder(@"C:\Users\evgen", 0);
        }
        private static void ShowAllFoldersUnder(string path, int indent)
        {
            try
            {
                if ((File.GetAttributes(path) & FileAttributes.ReparsePoint)
                    != FileAttributes.ReparsePoint)
                {
                    foreach (string folder in Directory.GetDirectories(path))
                    {
                        Console.WriteLine(
                            "{0}{1}", new string(' ', indent), Path.GetFileName(folder));
                        ShowAllFoldersUnder(folder, indent + 2);
                    }
                }
            }
            catch (UnauthorizedAccessException) { }
        }
        static void getAllFiles(string dir)
        {
            string[] tempFiles = Directory.GetFiles(dir);
            foreach (string tempFile in tempFiles)
            {
                checkFileCreationTime(tempFile);
            }
        }

        static void checkFileCreationTime(string filePath)
        {
            DateTime nowDate = DateTime.Now;
            DateTime creationTime = Directory.GetCreationTime(filePath);
            TimeSpan days = nowDate - creationTime;
            if (days.Days <= 14)
            {
                allFiles.Add(filePath);
            }
        }
    }
}
    


