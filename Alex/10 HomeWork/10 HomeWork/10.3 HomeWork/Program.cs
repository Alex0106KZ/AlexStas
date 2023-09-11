using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._3_HomeWork
{
    internal class Program
    {
        static int sumOfNumbers(int number)
        {
            if (number < 10)
                return number;

            return number % 10 + sumOfNumbers(number / 10);
        }

        static void Main(string[] args)
        {
            int number = 57896;

            Console.WriteLine(sumOfNumbers(number));

            Console.ReadKey();
        }
    }
}
