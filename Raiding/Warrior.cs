using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    internal class Warrior:BaseHero
    {
        public Warrior(string type, string name)
        {
            Type = type;
            Name = name;
            Power = 100;
        }
        public override string CastAbility()
        {
            return $"{Type} - {Name} hit for {Power} damage";
        }
    }
}
