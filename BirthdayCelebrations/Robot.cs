using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Robot : BaseEntity
    {
        string model;
        public string Model { get => model; set => Model = value; }
        public Robot(string model, string id)
        {
            Model = model;
            ID = id;
        }
    }
}
