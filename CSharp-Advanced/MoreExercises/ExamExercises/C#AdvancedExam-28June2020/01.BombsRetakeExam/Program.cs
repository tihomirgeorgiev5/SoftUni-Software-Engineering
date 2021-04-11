using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will be given a two sequence of //integers, representing bomb effects /and /bomb casings.
            //You need to start from the first bomb //effect and try to mix it with the last //bomb casing
            Queue<int> bombEffects = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            Stack<int> bombCasings = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            int daturaBomb = 0;
            int cherryBomb = 0;
            int smokeDecoyBomb = 0;
            int decrease = 0;
            // 5, 25, 50, 115
            // 5, 15, 25, 35
            int sum = 0;

            while (bombEffects.Count > 0 && bombCasings.Count > 0)
            {
                int currentBombEffect = bombEffects.Peek();
                int currentBombCasing = bombCasings.Peek() - decrease; ;
                bool bombCreated = false;

                int combinded = currentBombCasing + currentBombEffect;

                if (daturaBomb >=3 && cherryBomb >=3 && smokeDecoyBomb >=3)
                {
                    break;
                }

                if (combinded == 40)
                {
                    daturaBomb++;
                    bombCreated = true;
                }
                else if (combinded == 60)
                {
                    cherryBomb++;
                    bombCreated = true;
                }
                else if (combinded == 120)
                {
                    smokeDecoyBomb++;
                    bombCreated = true;
                }
                if (bombCreated)
                {
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                    decrease = 0;
                }
                else if (currentBombCasing <= 0)
                {
                    bombCasings.Pop();
                    decrease = 0;
                }
                else
                {
                    decrease += 5;
                }
            }

            if (daturaBomb >= 3 && cherryBomb >= 3 && smokeDecoyBomb >= 3)
            {
                Console.WriteLine($"Bene! You have successfully filled the bomb pouch!");
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

            Console.WriteLine($"Cherry Bombs: {cherryBomb}");
            Console.WriteLine($"Datura Bombs: {daturaBomb}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBomb}");


        }
    }
}
