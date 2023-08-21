using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray = new int[5];

            Console.WriteLine("Заполнение массива");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Введите число для "+ (i+1) + " ячейки массива: ");
                MyArray[i] =  Convert.ToInt16(Console.ReadLine());
            }

            Console.Write("Заполненный вами массив: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(MyArray[i]+ " ");
            }

            Console.ReadKey();  
        }
    }
}
