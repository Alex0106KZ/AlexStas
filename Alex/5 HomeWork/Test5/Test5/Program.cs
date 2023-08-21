using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число, определяющее размер треугольника: ");
            short Tsize = short.Parse(Console.ReadLine());

            //Первый треугольник

           for (int i = 0; i < Tsize; i++)
            {
                for ( int j = 0; j <= i ; j++) 
                {
                    Console.Write("&");
                }  

                Console.WriteLine();
            }

           Console.WriteLine();

            //Второй треугольник

            for (int i = 0; i < Tsize; i++)
            {
                for (int j = Tsize; j > i  ;j--)
                {
                    Console.Write("&");
                }
                Console.WriteLine();
            }

            //Третий треугольник

            for (int i = 0; i < Tsize; i++)
            {
                for (int j = 1; j < Tsize - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i+1; k++)
                {
                    Console.Write('&');
                }

                Console.WriteLine(); 
            }

            Console.WriteLine();    

            //Четвертый треугольник

            for (int i = 0; i < Tsize; i++)
            {
                for (int j = 1;  j < i + 1 ; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < Tsize - i ; k++)
                {
                    Console.Write("&");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
