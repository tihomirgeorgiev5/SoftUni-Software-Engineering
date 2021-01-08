using System;

namespace _02.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            VowelsCount(input);
        }
        static void VowelsCount(string word)
        {
            string newText = word.ToLower();
            int counter = 0;
            for (int i = 0; i < newText.Length; i++)
            {
                if ((int)newText[i] == 97 || (int)newText[i] == 101 || (int)newText[i] == 105 
                    || (int)newText[i] == 111 || (int)newText[i] == 117 || (int)newText[i] == 121)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
