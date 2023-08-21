using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Проверка числа на чётность-----");

            double a,b;

            Console.Write("Введите число: ");

            Double.TryParse(Console.ReadLine(),out a);

            if (a != 0)
            {
                b = a % 2;
                if (b == 0)
                {
                    Console.WriteLine("Введенное число " + "\""+ a +"\"" + " - чётное");
                }
                else
                {
                    Console.WriteLine("Введенное число " + "\"" + a + "\"" + " - нечётное");
                }

            }

                else 
            
                {
                    Console.WriteLine("Введено неккоректное число!");
                }

            Console.ReadKey();
            
        }
    }
}
