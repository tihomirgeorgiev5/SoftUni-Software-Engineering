using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPokePower = int.Parse(Console.ReadLine());
            int mDistanceTargets = int.Parse(Console.ReadLine());
            byte yExhaustion = byte.Parse(Console.ReadLine());

            int countTargets = 0;
            double tempPower = nPokePower * 0.5;

            while (nPokePower >= mDistanceTargets)
            {
                nPokePower -= mDistanceTargets;
                countTargets++;

                if(nPokePower == tempPower && yExhaustion != 0)
                {
                    nPokePower /= yExhaustion;
                }
              
            }
            Console.WriteLine(nPokePower);
            Console.WriteLine(countTargets);

        }
    }
}
