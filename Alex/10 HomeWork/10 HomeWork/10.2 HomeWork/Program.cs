using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2_HomeWork
{
    internal class Program
    {
        // КОНЧЕНЫННЫЙ ВАРИАНТ РЕШЕНИЯ
        // НЕ НАДО РАБОТАТЬ С ЧИСЛАМИ ЧЕРЕЗ СТРОКИ
        static void sumOfNumbers(string str, int newSum, int i)
        {
            if (i >= str.Length)
            {
                Console.WriteLine(newSum);
                return;
            }

            int intChar = (int)Char.GetNumericValue(str[i]);
            newSum =  intChar + newSum;

            sumOfNumbers(str, newSum, i+1);

        }

        static void Main(string[] args)
        {
            int i = 0;
            int newSum = 0;
 
            string str = "57896";

            sumOfNumbers(str, newSum, i);

            Console.ReadKey();


        }
    }
}
