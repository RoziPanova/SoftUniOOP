using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    internal abstract class BaseHero
    {
        string type;
        string name;
        int power;
        public string Type { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }

        public virtual string CastAbility()
        {
            return $"{Type} - {Name} healed for {Power}";
        }
    }
}
