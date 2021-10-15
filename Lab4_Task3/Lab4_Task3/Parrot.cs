using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab4_Task3
{
    class Parrot : Animal
    {
        private string type;
        private string name;
        private string sings;
        private string color;
        private string country;

        public Parrot()
        {
            type = "Parrot";
            name = "Artist";
            sings = "Yes";
            color = "Multicolor";
            country = "Brazil";

        }

        public override void Print()
        {
            Debug.WriteLine($"Type: {type}");
            Debug.WriteLine($"Name: {name}");
            Debug.WriteLine($"Sings: {sings}");
            Debug.WriteLine($"Color: {color}");
            Debug.WriteLine($"Country: {country}");
        }
    }
}
