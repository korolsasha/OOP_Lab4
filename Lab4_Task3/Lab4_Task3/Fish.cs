using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab4_Task3
{
    class Fish : Animal
    {
        private string type;
        private string name;
        private string size;
        private string color;
        private string place;

        public Fish()
        {
            type = "Fish";
            name = "Swimmy";
            size = "Medium";
            color = "Yellow";
            place = "Pond";

        }

        public override void Print()
        {
            Debug.WriteLine($"Type: {type}");
            Debug.WriteLine($"Name: {name}");
            Debug.WriteLine($"Size: {size}");
            Debug.WriteLine($"Color: {color}");
            Debug.WriteLine($"Place of living: {place}");
        }
    }
}
