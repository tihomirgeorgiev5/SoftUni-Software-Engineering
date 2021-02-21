using System;
using System.IO;

namespace _01.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\43650\source\repos\STREAMS, FILES AND DIRECTORIES\01.Odd Lines\input.txt")) 
            {
                string currentRow = reader.ReadLine();
                int row = 0;
                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    while(currentRow != null)
                    {
                        if (row % 2 != 0)
                        {
                            writer.WriteLine(currentRow);
                        }

                        currentRow = reader.ReadLine();
                        row++;
                    }
                }
                    
                
            }

            //string line = reader.ReadLine();
            //
            //Console.WriteLine(line);
            //
            //reader.Close();
        }   // 
    }
}
