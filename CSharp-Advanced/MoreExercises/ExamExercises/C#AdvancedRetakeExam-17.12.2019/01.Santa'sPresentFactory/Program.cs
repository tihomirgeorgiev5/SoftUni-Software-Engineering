using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Santa_sPresentFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack countOfMaterialsInOneBox()
            //Queue magicLevel

            Stack<int> materialValue = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());

            Queue<int> magicLevel = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());



            Dictionary<int, string> presentsMagicLevel = new Dictionary<int, string>
            {
                { 150, "Doll"},
                { 250, "Wooden train"},
                { 300, "Teddy bear"},
                { 400, "Bicycle"},

            };

            Dictionary<string, int> presentsMade = new Dictionary<string, int>();

            while (materialValue.Count > 0 && magicLevel.Count > 0 )
            {
                int totalMagicLevel = materialValue.Peek() * magicLevel.Peek();

                if (presentsMagicLevel.ContainsKey(totalMagicLevel))
                {
                    if (!presentsMade.ContainsKey(presentsMagicLevel[totalMagicLevel]))
                    {
                        presentsMade.Add(presentsMagicLevel[totalMagicLevel], 0);

                    }
                    presentsMade[presentsMagicLevel[totalMagicLevel]]++;

                    materialValue.Pop();
                    magicLevel.Dequeue();

                }
                else
                {
                    if (totalMagicLevel < 0)
                    {
                        int sum = materialValue.Peek() + magicLevel.Peek();
                        materialValue.Pop();
                        magicLevel.Dequeue();
                        materialValue.Push(sum);
                    }
                    else if (totalMagicLevel > 0)
                    {
                        int material = materialValue.Peek() + 15;
                        materialValue.Pop();
                        magicLevel.Dequeue();
                        materialValue.Push(material);
                    }
                    else if (totalMagicLevel == 0)
                    {
                        if (materialValue.Peek() == 0)
                        {
                            materialValue.Pop();
                        }
                        if (magicLevel.Peek() == 0)
                        {
                            magicLevel.Dequeue();
                        }
                    }
                }
            }

            if ((presentsMade.ContainsKey("Doll") && presentsMade.ContainsKey("Wooden train")) || (presentsMade.ContainsKey("Teddy bear") && presentsMade.ContainsKey("Bicycle")))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }
            if (materialValue.Count > 0)
            {
                Console.WriteLine("Materials left: " + string.Join(", ", materialValue));
            }
            if (magicLevel.Count > 0)
            {
                Console.WriteLine("Magic left: " + string.Join(", ", magicLevel));
            }
            foreach (var present in presentsMade.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{present.Key} : {present.Value}");
            }
        }

    }
}
