using System;
//using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            /*NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };*/

            Console.Write("Введите первое число: ");
            a = Double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            b = System.Convert.ToDouble(Console.ReadLine());

            double result = (a + b) / 2;
            Console.WriteLine("Среднее арифметичесмкое этих чисел = " + result);

            Console.ReadKey();
         
        }
    }
}
