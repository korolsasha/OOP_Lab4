using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab4_Task1
{
    public class Second_Class : First_Class
    {
        public new void Print(params object[] args)
        {
            // Я не нашёл как можно покрасить debug
            Debug.WriteLine("Arguments and their types:");

            foreach (var arg in args)
            {
                Debug.WriteLine($"{arg.GetType()}: {arg}");
            }
        }
    }
}
