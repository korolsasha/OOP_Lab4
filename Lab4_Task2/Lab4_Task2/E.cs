using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab4_Task2
{
    public class E : B
    {
        public override void PrintProperties()
        {
            Debug.WriteLine("");
            Debug.WriteLine("E class:");
            Debug.WriteLine($"Properties: some E class properties");
        }
    }
}
