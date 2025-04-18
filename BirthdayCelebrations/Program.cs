using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Birthdate birthdate = new Birthdate();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 5 && tokens[0] == "Citizen")
                {
                    var citizen = new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]);
                    birthdate.AddEntityBirthdate(citizen);
                }
                else if (tokens.Length == 3 && tokens[0]=="Pet")
                {
                    var pet = new Pet(tokens[1], tokens[2]);
                    birthdate.AddEntityBirthdate(pet);
                }
            }
            string year = Console.ReadLine();
            var matches = birthdate.Entities.Where(x => x.Birthdate.EndsWith(year));
            foreach (var match in matches) 
            {
                Console.WriteLine(match.Birthdate);
            }
        }
    }
}
/*
Robot VV-XYZ 11213141
Citizen Corso 35 7903210713 21/03/1979
Citizen Kane 40 7409073566 07/09/1974
End
1975
 */
