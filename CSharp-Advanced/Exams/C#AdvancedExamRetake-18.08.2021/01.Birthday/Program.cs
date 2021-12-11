using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
             while (hatsStack.Count > 0 && scarfsQueue.Count > 0)
            {
                int hat = hatsStack.Peek();
                int scarf = scarfsQueue.Peek();
                if (hat > scarf)
                {
                    int set = hat + scarf;
                    hatsStack.Pop();
                    scarfsQueue.Dequeue();
                    sets.Add(set);
                }
                if (scarf > hat)
                {
                    //remove hat and check next one
                    hatsStack.Pop();
                    continue;*/
            int wastedFood = 0;
            List<int> full = new List<int>();
            int[] eatingCapacity = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] plates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> guestsQueue = new Queue<int>(eatingCapacity);
            Stack<int> plateStack = new Stack<int>(plates);

           

            while (plateStack.Count > 0 && guestsQueue.Count > 0)
            {
                int currentPlate = plateStack.Peek();
                int currentGuest = guestsQueue.Peek();
                if((currentPlate - currentGuest) > 0)
                {
                    wastedFood += currentPlate - currentGuest;
                }

                
                    plateStack.Pop();
                    guestsQueue.Dequeue();

                

                if (guestsQueue.Count <= 0)
                {
                    break;
                }

                if (plateStack.Count <= 0)
                {
                    break;
                }

            }
            if (guestsQueue.Count <= 0)
            {
                Console.WriteLine($"Plates: {string.Join(" ", plateStack)}");
                Console.WriteLine($"Wasted grams of food: {wastedFood}");
            }

            if (plateStack.Count <= 0)
            {
                Console.WriteLine($"Guests: {string.Join(" ", guestsQueue)}");
                Console.WriteLine($"Wasted grams of food: {wastedFood}");

            }





        }
    }
}
