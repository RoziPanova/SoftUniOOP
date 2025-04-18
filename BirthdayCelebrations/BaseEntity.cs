using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public abstract class BaseEntity
    {
        public string ID { get; set; }
        public string Birthdate { get; set; }
    }
}
