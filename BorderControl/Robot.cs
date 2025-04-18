using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robot : BaseEntity
    {
        string model;
        public string Model { get; set; }

        public Robot(string model, string id)
        {
            Model = model;
            ID = id;
        }
    }
}
