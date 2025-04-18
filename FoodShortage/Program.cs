using BirthdayCelebrations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Citizen> citizens = new List<Citizen>();
            List<Rebel> rebels = new List<Rebel>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input.Length == 4)
                {
                    citizens.Add(new Citizen(input[0], int.Parse(input[1]), input[2], input[3]));
                }
                else
                {
                    rebels.Add(new Rebel(input[0], int.Parse(input[1]), input[2]));
                }
            }
            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                var citizen=citizens.FirstOrDefault(x=>x.Name==line);
                var rebel=rebels.FirstOrDefault(x=>x.Name==line);
                if (citizen != null)
                {
                    citizen.BuyFood();
                }
                if (rebel != null)
                {
                    rebel.BuyFood();
                }
            }
            int totalFood = 0;
            foreach (var item in citizens)
            {
                totalFood += item.Food;
            }
            foreach (var item in rebels)
            {
                totalFood += item.Food;
            }
            Console.WriteLine(totalFood);
        }
    }
}
/*
4
Stam 23 TheSwarm
Ton 44 7308185527 18/08/1973
George 31 Terrorists
Pen 27 881222212 22/12/1988
John
Geo rge
John
Joro
Stam
Pen
End
 */
