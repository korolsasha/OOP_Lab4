using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab4_Task3
{
    class Animal
    {
        private string type;
        private string name;
        private int age;

        public Animal()
        {
            type = "Hamster";
            name = "Runny";
            age = 2;
        }

        public virtual void Print()
        {
            Debug.WriteLine($"Type: {type}");
            Debug.WriteLine($"Name: {name}");
            Debug.WriteLine($"Age: {age}");
        }
    }
}
