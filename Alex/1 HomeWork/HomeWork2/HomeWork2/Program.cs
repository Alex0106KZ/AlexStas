using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d ,e;

            Console.Write("Введите первое число: ");
            a = System.Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            b = Double.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            c = System.Convert.ToDouble(Console.ReadLine());

            d = a + b + c;
            e = a * b * c;

            Console.WriteLine("Сумма этих трех чисел = " + d);
            Console.WriteLine("Произведение этих трех чисел = " + e);

            Console.ReadLine();
        }
    }
}
