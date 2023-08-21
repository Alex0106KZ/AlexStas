using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_demention_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание границ массива");
            
            Console.Write("Введите i: ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Введите j: ");
            int second = int.Parse(Console.ReadLine());

            Console.Write("Введите k: ");
            int third = int.Parse(Console.ReadLine());

            int[,,] MyArray = new int[first, second ,third];

            //Заполнение массива случайными числами

            Random random = new Random();

            for (int i = 0; i < MyArray.GetLength(0); i++)
            {
                for (int j = 0; j < MyArray.GetLength(1); j++)
                {
                    for (int k = 0; k < MyArray.GetLength(2); k++)
                    {
                        MyArray[i, j, k] = random.Next(100); 
                    }
                }
            }

            Console.Clear();

            //Вывод массива

            for (int i = 0; i < MyArray.GetLength(0); i++)
            {
                Console.WriteLine("------------------------");
                for (int j = 0; j < MyArray.GetLength(1); j++)
                {
                    for (int k = 0; k < MyArray.GetLength(2); k++)
                    {
                        Console.Write(MyArray[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }



            Console.ReadLine();
        }
    }
}
