using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите число, определяющее размер треугольника: ");

            short TSize = short.Parse(Console.ReadLine());

            //Треугольник #1

            for (int i = 0; i < TSize; i++)
            {
                for (int j = 0; (j < i + 1); j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //Треугольник #2

            for (int i = 0; i < TSize; i++)
            {
                for (int j = 0; j<TSize-i; j++)
                {
                   Console.Write("#");
                }
               Console.WriteLine();
            }

            Console.WriteLine();

            //Треуголник #3

            for (int i = 0; i<TSize; i++)
            {
                for (int j = 1;j<TSize-i ; j++)
                {
                    Console.Write(" ");
                }
               

                for (int k = 0; k < i+1 ; k++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }

           
            Console.WriteLine();

            //Треугольник #4

            for (int i = 0; i < TSize; i++)
            {
                for (int j = 0; j < TSize - i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();

                for (int k = 0; (k < i + 1); k++)
                {
                    Console.Write(" ");
                }
            }

            Console.ReadKey();
        }
    }
}
