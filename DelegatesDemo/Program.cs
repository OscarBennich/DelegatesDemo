using System;
using System.IO;

namespace DelegatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirPath = @"C:\Users\W100567\Desktop\Textfolder";

            // C# 1.0 (named delegates)
            FileFinder.Find(dirPath, MyTextFilter);

            // C# 2.0 (anonymous delegates)
            FileFinder.Find(dirPath, delegate(string filePath)
            {
                return string.Equals(Path.GetExtension(filePath), ".txt", 
                    StringComparison.OrdinalIgnoreCase);
            });

            // C# 3.0 (lambda expression)
            FileFinder.Find(dirPath, p => string.Equals(Path.GetExtension(p), ".txt", StringComparison.OrdinalIgnoreCase));
        }

        static bool MyTextFilter(string filePath)
        {
            return string.Equals(Path.GetExtension(filePath), ".txt", StringComparison.OrdinalIgnoreCase);
        }
    }
}
