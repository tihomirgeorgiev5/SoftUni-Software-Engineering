using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchBook = Console.ReadLine();
            string currentBook = Console.ReadLine();
            bool isFound = false;
            int checkedBooks = 0;

            while (currentBook != "No More Books")
            {
                if (searchBook == currentBook)
                {
                    isFound = true;
                    break;
                }
                checkedBooks++;
                currentBook = Console.ReadLine();

            }

            if (isFound)
            {
                Console.WriteLine($"You checked {checkedBooks} books and found it.");
            }

            if (currentBook == "No More Books") 
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooks} books.");

            }

        }
    }
}
