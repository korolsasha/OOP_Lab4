using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab4_Task1
{
    public class First_Class
    {
        public void Print(params object[] args)
        {
            Debug.WriteLine("Arguments:");

            foreach (var arg in args)
            {
                Debug.WriteLine(arg);
            }

            Debug.WriteLine("");
        }
    }
}
