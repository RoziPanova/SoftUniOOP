using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    internal class Paladin : BaseHero
    {
        public Paladin(string type, string name)
        {
            Type = type;
            Name = name;
            Power = 100;
        }
    }
}
