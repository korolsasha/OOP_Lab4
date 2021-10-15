using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Task4
{
    public class Rectangle
    {
        public double side1, side2, result;
        public int option;
        public void Input()
        {
            Console.Write("Оберіть обчислюваний параметр: ");
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Введіть сторону №1 прямокутника: ");
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть сторону №2 прямокутника: ");
            side2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
        }
    }
}
