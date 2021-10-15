using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab4_Task2
{
    public class C : B
    {
        public string Text { get; set; } = "";

        public C(string text)
        {
            Text = text;
        }

        public override void PrintProperties()
        {
            Debug.WriteLine("");
            Debug.WriteLine("C class:");
            Debug.WriteLine($"Text: {Text}");
        }
    }
}
