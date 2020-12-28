using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int bestLength = 1;
            int bestStartIndex = 0;
            int bestSiquenceSum = 0;
            int bestSiquenceIndex = 0;
            int[] bestSiquence = new int[n];

            int sequenceCounter = 0;

            while (input != "Clone them!")
            {
                    int[] currentSiquence = input
                        .Split("!", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                sequenceCounter++;
                int length = 1;
                int bestCurrentLength = 1;
                int startIndex = 0;
                int currentSequenceSum = 0;
               

                for (int i = 0; i < currentSiquence.Length - 1; i++)
                {
                    if(currentSiquence[i] == currentSiquence[i + 1])
                    {
                        length++;
                    }
                    else
                    {
                        length = 1;
                    }
                    if(length > bestCurrentLength)
                    {
                        bestCurrentLength = length;
                        startIndex = i; 
                    }
                    currentSequenceSum += currentSiquence[i];
                }
                currentSequenceSum += currentSiquence[n - 1];

                // 1.Read an integer n
                // 2. Read sequences until we receive "Clone them!"
                // 3. For each sequence find the longest subsequence
                // 4.Keep track of:
                // 4.1 The starting index of the longest subsequence
                // 4.2 The sum of the sequence's elements
                // 4.3 'The length of the longest subsequence
                // 5. Compare the current sequence  to the best sequence
                //    so far and change the best sequence if needed.
                // 6. Print output

                if(bestCurrentLength > bestLength)
                {
                    bestLength = bestCurrentLength;
                    bestStartIndex = startIndex;
                    bestSiquenceSum = currentSequenceSum;
                    bestSiquenceIndex = sequenceCounter;
                    bestSiquence = currentSiquence.ToArray();
                }
                else if(bestCurrentLength == bestLength)
                {
                    if(startIndex < bestStartIndex)
                    {
                        bestLength = bestCurrentLength;
                        bestStartIndex = startIndex;
                        bestSiquenceSum = currentSequenceSum;
                        bestSiquenceIndex = sequenceCounter;
                        bestSiquence = currentSiquence.ToArray();
                    }
                    else if(startIndex == bestStartIndex)
                    {
                        if(currentSequenceSum > bestSiquenceSum)
                        {
                            bestLength = bestCurrentLength;
                            bestStartIndex = startIndex;
                            bestSiquenceSum = currentSequenceSum;
                            bestSiquenceIndex = sequenceCounter;
                            bestSiquence = currentSiquence.ToArray(); 
                        }
                    }
                }


                input = Console.ReadLine();


            }
            Console.WriteLine($"Best DNA sample {bestSiquenceIndex} with sum: {bestSiquenceSum}.");
            Console.WriteLine(String.Join(" ",bestSiquence));

        }
    }
}
