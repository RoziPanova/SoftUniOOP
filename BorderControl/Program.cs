using System;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            BorderControl borderControl = new BorderControl();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 2)
                {
                    var robot = new Robot(tokens[0], tokens[1]);
                    borderControl.AddEntenty(robot);
                }
                else
                {
                    var citizen = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    borderControl.AddEntenty(citizen);
                }
            }
            string check = Console.ReadLine();
            var detained = borderControl.Entities.Where(x => x.ID.EndsWith(check));
            foreach (var item in detained)
            {
                Console.WriteLine(item.ID);
            }
        }
    }
}


