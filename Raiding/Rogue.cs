using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    internal class Rogue:BaseHero
    {
        public Rogue(string type, string name)
        {
            Type = type;
            Name = name;
            Power = 80;
        }
        public override string CastAbility()
        {
            return $"{Type} - {Name} hit for {Power} damage";
        }
    }
}
