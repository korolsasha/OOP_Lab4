using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab4_Task3
{
    class Cat : Animal
    {
        private string type;
        private string name;
        private string happy;
        private int prizes;

        public Cat()
        {
            type = "Cat";
            name = "Silvy";
            happy = "Yes";
            prizes = 12;

        }

        public override void Print()
        {
            Debug.WriteLine($"Type: {type}");
            Debug.WriteLine($"Name: {name}");
            Debug.WriteLine($"Happy: {happy}");
            Debug.WriteLine($"Prizes: {prizes}");
        }
    }
}
