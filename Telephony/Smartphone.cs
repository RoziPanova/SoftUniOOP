using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Smartphone : ISmartphone
    {
        public Smartphone() { }
        public void Calling(string number)
        {
            Console.WriteLine($"Calling... {number}");
        }
        public void Browsing(string url)
        {
            Console.WriteLine($"Browsing: {url}!");
        }
    }
}
