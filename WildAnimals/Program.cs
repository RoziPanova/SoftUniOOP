using System;
using System.Collections.Generic;
using System.Linq;

namespace WildAnimals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();
            while (true)
            {
                string[] animal = Console.ReadLine().Split(" ");
                if (animal[0] == "End")
                {
                    break;
                }
                string[] food = Console.ReadLine().Split(" ");

                switch (animal[0])
                {
                    case "Hen":
                        list.Add(new Hen(animal[0], animal[1], double.Parse(animal[2]), double.Parse(animal[3])));
                        break;
                    case "Owl":
                        list.Add(new Owl(animal[0], animal[1], double.Parse(animal[2]), double.Parse(animal[3])));
                        break;
                    case "Cat":
                        list.Add(new Cat(animal[0], animal[1], double.Parse(animal[2]), animal[3], animal[4]));
                        break;
                    case "Tiger":
                        list.Add(new Tiger(animal[0], animal[1], double.Parse(animal[2]), animal[3], animal[4]));
                        break;
                    case "Mouse":
                        list.Add(new Mouse(animal[0], animal[1], double.Parse(animal[2]), animal[3]));
                        break;
                    case "Dog":
                        list.Add(new Dog(animal[0], animal[1], double.Parse(animal[2]), animal[3]));
                        break;
                    default:
                        break;
                }
                list.Last().Feed(food[0], int.Parse(food[1]));
            }
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
/*
Mouse Jerry 0,5 Anywhere
Fruit 1000
Owl Tom 2,5 30
Meat 5
End
 */
