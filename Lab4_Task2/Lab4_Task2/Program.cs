using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab4_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A(new C("Test"), new D(), new E());

            a.PrintProperties();
            Console.ReadLine();
        }
    }
}
