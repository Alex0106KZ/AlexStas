using System;
using System.Globalization;

namespace Summa3
{
    class Program
    {
        static void Main(string[] args)
        {
            string first, second, third;
            int a, b, c, summaresult, umnozhenieresult;

            Console.WriteLine("Введите 3 числа:");
            first = Console.ReadLine();
            second = Console.ReadLine();
            third = Console.ReadLine();

            a = int.Parse(first);
            b = int.Parse(second);
            c = int.Parse(third);

            summaresult = a + b + c;
            umnozhenieresult = a * b * c;  
            Console.WriteLine("Сумма 3 твоих чисел равна = " + summaresult + " Умножение равно ="+ umnozhenieresult);
        }
    }
}
