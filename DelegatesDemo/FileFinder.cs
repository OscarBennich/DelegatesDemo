using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DelegatesDemo
{
    //delegate bool FileFilter(string path);

    static class FileFinder
    {
        public static void Find(string dirPath, Func<string, bool> filter)
        {
            string[] filePaths = Directory.GetFiles(dirPath);
            foreach (string filePath in filePaths)
            {
                if (filter(filePath))
                {
                    Console.WriteLine(filePath);
                }
            }
        }
    }
}