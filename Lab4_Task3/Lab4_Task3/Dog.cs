using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab4_Task3
{
    class Dog : Animal
    {
        private string type;
        private string name;
        private string breed;
        private string color;
        private int age;

        public Dog()
        {
            type = "Dog";
            name = "Jeff";
            breed = "Golder retriever";
            color = "Golden";
            age = 2;
        }

        public override void Print()
        {
            Debug.WriteLine($"Type: {type}");
            Debug.WriteLine($"Name: {name}");
            Debug.WriteLine($"Breed: {breed}");
            Debug.WriteLine($"Color: {color}");
            Debug.WriteLine($"Age: {age}");
        }
    }
}
