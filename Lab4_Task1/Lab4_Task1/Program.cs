using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab4_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Second_Class sec = new Second_Class();
            First_Class fir= (First_Class)sec;

            fir.Print
                (
                    567,
                    1.78f,
                    2.7d,
                    64.73m,
                    'a',
                    "Рядок",
                    new object(),
                    DateTime.Now
                );

            sec.Print
                (
                    567,
                    1.78f,
                    2.7d,
                    64.73m,
                    'a',
                    "Рядок",
                    new object(),
                    DateTime.Now
                );

            Console.ReadLine();
        }
    }
}
