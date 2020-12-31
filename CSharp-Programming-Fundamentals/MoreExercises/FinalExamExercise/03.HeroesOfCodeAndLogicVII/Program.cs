using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Dictionary<string, int> heroMP =
                new Dictionary<string, int>();
            Dictionary<string, int> heroHP =
                new Dictionary<string, int>();

            int hpMax = 100;
            int mpMax = 200;

            for (int i = 0; i < n; i++)
            {
                string[] heroes = Console.ReadLine()
                    .Split();
                string heroName = heroes[0];
                int hp = int.Parse(heroes[1]);
                int mp = int.Parse(heroes[2]);

                heroHP[heroName] = hp > hpMax ? hpMax : hp;
                heroMP[heroName] = mp > mpMax ? mpMax : mp;
            }

            string input = Console.ReadLine();

            while (true)
            {
                if (input == "End")
                {
                    break;
                }

                string[] commands = input
                .Split(" - ");

                string currentCommand = commands[0];
                string heroName = commands[1];

                switch (currentCommand)
                {
                    case "CastSpell":
                        int neededMP = int.Parse(commands[2]);
                        string spellName = commands[3];
                        if (heroMP[heroName] >= neededMP)
                        {
                            heroMP[heroName] -= neededMP;
                            Console.WriteLine($"{heroName} has successfully cast {spellName}" +
                                $" and now has {heroMP[heroName]} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");

                        }
                        break;
                    case "TakeDamage":
                        int damage = int.Parse(commands[2]);
                        string attacker = commands[3];
                        heroHP[heroName] -= damage;
                        if (heroHP[heroName] > 0)
                        {
                            Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker}" +
                                $" and now has {heroHP[heroName]} HP left!");
                        }
                        else
                        {
                            heroHP.Remove(heroName);
                            heroMP.Remove(heroName);
                            Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        }

                        break;
                    case "Recharge":
                        int amount = int.Parse(commands[2]);
                        int mpBefore = heroMP[heroName];
                        heroMP[heroName] += amount;
                        
                        if (heroMP[heroName] >= mpMax)
                        {
                            heroMP[heroName] = mpMax;
                            
                        }
                        int mpAfter = heroMP[heroName];
                        int totalAmount = mpAfter - mpBefore;

                        Console.WriteLine($"{heroName} recharged for {totalAmount} MP!");
                        

                        break;
                    case "Heal":
                        int healAmount = int.Parse(commands[2]);
                        int hpBefore = heroHP[heroName];
                        heroHP[heroName] += healAmount;

                        if (heroHP[heroName] > hpMax)
                        {
                            heroHP[heroName] = hpMax;

                        }
                        int hpAfter = heroHP[heroName];
                        int totalHealAmount = hpAfter - hpBefore;
                        Console.WriteLine($"{heroName} healed for {totalHealAmount} HP!");
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (var hero in heroHP.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{hero.Key}");
                Console.WriteLine($"  HP: {hero.Value}");
                Console.WriteLine($"  MP: {heroMP[hero.Key]}");

            }

            

        }
    }
}
