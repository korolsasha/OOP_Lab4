using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab4_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animal = new[]
            {
                new Animal(),
                new Dog(),
                new Cat(),
                new Parrot(),
                new Fish()
            };

            foreach (var classes in animal)
            {
                classes.Print();
                Debug.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
