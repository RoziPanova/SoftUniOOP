using System;
using System.Collections.Generic;

namespace Raiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BaseHero> heros = new List<BaseHero>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();
                switch (type)
                {
                    case "Druid":
                        heros.Add(new Druid(type, name));
                        break;
                    case "Paladin":
                        heros.Add(new Paladin(type, name));
                        break;
                    case "Rogue":
                        heros.Add(new Rogue(type, name));
                        break;
                    case "Warrior":
                        heros.Add(new Warrior(type, name));
                        break;
                    default:
                        Console.WriteLine("Invalid hero!");
                        i--;
                        break;
                }

            }
            int bossPower = int.Parse(Console.ReadLine());
            int powerSum = 0;
            foreach (var item in heros)
            {
                Console.WriteLine(item.CastAbility());
                powerSum += item.Power;
            }
            if (powerSum >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
