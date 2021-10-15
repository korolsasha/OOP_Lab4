using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Task4
{
    class Pro : Rectangle
    {
        public void Instruction()
        {
            Console.WriteLine("У вас про версія");
            Console.WriteLine("");
            Console.WriteLine("Ця програма дає можливість обчислити такі параметри прямокутника, як:");
            Console.WriteLine("1. Периметр");
            Console.WriteLine("2. Площа");
            Console.WriteLine("3. Довжина діагоналі");
            Console.WriteLine("");
        }

        public void Calculate()
        {
            switch (option)
            {
                case 1:
                    result = (side1 + side2) * 2;
                    break;
                case 2:
                    result = side1 * side2;
                    break;
                case 3:
                    result = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
                    break;
            }
        }

        public void Print()
        {
            if (option == 1)
            {
                Console.WriteLine($"Периметр = {result}");
            }

            if (option == 2)
            {
                Console.WriteLine($"Площа = {result}");
            }

            if (option == 3)
            {
                Console.WriteLine($"Діагональ = {result}");
            }
        }

        public Pro()
        {
            Instruction();
            Input();
            Calculate();
            Print();
        }
    }
}
