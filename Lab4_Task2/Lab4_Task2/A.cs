using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab4_Task2
{
    public class A
    {
        public B[] Args;

        public A(B b1, B b2)
        {
            Args = new[] { b1, b2 };
        }

        public A(B b1, B b2, B b3)
        {
            Args = new[] { b1, b2, b3 };
        }

        public void PrintProperties()
        {
            Debug.WriteLine("Args properties:");

            foreach (var a in Args)
            {
                a.PrintProperties();
            }

        }
    }
}
