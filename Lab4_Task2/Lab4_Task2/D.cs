using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab4_Task2
{
    public class D : B
    {
        public DateTime Time;

        public D()
        {
            Time = DateTime.Now;
        }

        public override void PrintProperties()
        {
            Debug.WriteLine("");
            Debug.WriteLine("D class:");
            Debug.WriteLine($"Time: {Time}");
        }
    }
}
