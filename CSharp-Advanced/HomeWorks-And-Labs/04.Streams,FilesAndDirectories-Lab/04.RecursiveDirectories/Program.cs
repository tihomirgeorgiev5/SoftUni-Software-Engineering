using System;
using System.IO;

namespace _04.RecursiveDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderPath = Console.ReadLine();

            var files = Directory.GetFiles(folderPath);

            long fileSize = 0;

            foreach (var filePath in files)
            {
                FileInfo file = new FileInfo(filePath);

                Console.WriteLine(file.FullName);
                Console.WriteLine(file.Length);
                Console.WriteLine(file.Extension);

                fileSize += file.Length;
            }

            Console.WriteLine(fileSize / 1024.0);
        }
    }
}
