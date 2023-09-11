using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._4_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            while (number > 0) 
            {
                sum += number % 10;
                
                number = number / 10;
            }

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
