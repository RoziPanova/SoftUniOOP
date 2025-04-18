using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    internal class Druid : BaseHero
    {
        public Druid(string type,string name)
        {
            Type= type; 
            Name= name;
            Power= 80;
        }

    }
}
