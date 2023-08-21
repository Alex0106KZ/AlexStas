using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-----Узнаем количество четных и нечетных чисел из диапазона-----");

                int FirstValue, LastValue, even, odd;

                even = 0;
                odd = 0;

                try
                {
                    Console.Write("Введите первое число диапазона: ");
                    FirstValue = int.Parse(Console.ReadLine());

                    Console.Write("Введите последнее число диапазона: ");
                    LastValue = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Введено некоректное число!");
                    Console.ReadKey();
                    continue;
                }

                while (FirstValue <= LastValue)
                {

                    if (FirstValue % 2 == 0)
                        even++;
                    else
                        odd++;

                    FirstValue++;
                }

                Console.WriteLine("Количество четных: " + even);
                Console.WriteLine("Количество нечетных: " + odd);
                Console.ReadKey();
            }


        }
    }
}
