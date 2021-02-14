using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> bombEffects = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());

            Stack<int> bombCasings = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());

            Console.WriteLine(string.Join(", ", bombEffects ));

            Console.WriteLine(string.Join(", ", bombCasings));

            int datura = 0;
            int cherry = 0;
            int smoke = 0;
            int decrease = 0;


            while (bombEffects.Count > 0 && bombCasings.Count > 0)
            {
                if (datura >= 3 && cherry >= 3 && smoke >= 3)
                {
                    break;
                }
                int currentEffect = bombEffects.Peek();
                int currentCase = bombCasings.Peek() - decrease; 
                int combined = currentCase + currentEffect;
                bool bombCreated = false;

                if (combined == 40)
                {
                    datura++;
                    bombCreated = true;
                }
                else if (combined == 60)
                {
                    cherry++;
                    bombCreated = true;
                }
                else if (combined == 120)
                {
                    smoke++;
                    bombCreated = true;
                }
                if (bombCreated)
                {
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                    decrease = 0;
                }
                else if (currentCase <= 0)
                {
                    bombCasings.Pop();
                    decrease = 0;
                }
                else
                {
                    decrease += 5;
                }

            }

            if (datura >= 3 && cherry >= 3 && smoke >= 3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            if (bombEffects.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffects)}");
            }
            if (bombCasings.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasings)}");
            }

            Console.WriteLine($"Cherry Bombs: {cherry}");
            Console.WriteLine($"Datura Bombs: {datura}");
            Console.WriteLine($"Smoke Decoy Bombs: {smoke}");

        }
    }
}
