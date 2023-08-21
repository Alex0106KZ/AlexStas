using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Round
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double a;
            Console.Write("Введите число: ");
            a = System.Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Округленное число методом \"ToEven\" = " + Math.Round(a,2,MidpointRounding.ToEven));
            Console.WriteLine("Округленное число методом \"AwayFromZero\" = " + Math.Round(a, 2, MidpointRounding.AwayFromZero));
            Console.ReadKey();
        }
    }
}
