using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Task4
{
    class Trial : Rectangle
    {
        public void Instruction()
        {
            Console.WriteLine("У вас триальна версія");
            Console.WriteLine("");
            Console.WriteLine("Ця програма дає можливість обчислити такі параметри прямокутника, як:");
            Console.WriteLine("1. Периметр");
            Console.WriteLine("2. Площа");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("3. Довжина діагоналі");
            Console.ResetColor();
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Параметр не доступний для триальної версії");
                    Console.ResetColor();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Такого параметру не існує");
                    Console.ResetColor();
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
        }

        public Trial()
        {
            Instruction();
            Input();
            Calculate();
            Print();
        }
    }
}
