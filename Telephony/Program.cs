using System;
using System.Linq;

namespace Telephony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] urls = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();
            foreach (string num in numbers)
            {
                bool result = num.Any(x => char.IsLetter(x));
                if (result)
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }
                if (num.Length == 10)
                {
                    smartphone.Calling(num);
                }
                else if (num.Length == 7)
                {
                    stationaryPhone.Dialing(num);
                }
            }
            foreach (string url in urls)
            {
                bool result = url.Any(x => char.IsDigit(x));
                if (result)
                {
                    Console.WriteLine("Invalid URL!");
                    continue;
                }
                smartphone.Browsing(url);
            }
        }
    }
}
/*
0882134215 0882134333 0899213421 0558123 3333123
http://softuni.bg http://youtube.com http://www.g00gle.com
 */
