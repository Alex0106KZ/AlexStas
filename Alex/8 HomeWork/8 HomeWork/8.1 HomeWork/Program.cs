using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_HomeWork
{


    internal class Program
    {
        static int FindIndex(int[] arr, int number)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i]  == number)
                    return i;
            return -1;
        }
        static void Main(string[] args)
        {
            //Создание случайного массива

            Random random = new Random();
            int[] MyArray = new int[random.Next(20)];

            //Заполнение массива случайными числами

            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = random.Next(100);
            }

            //Вывод массива в консоль

            for (int i = 0;i < MyArray.Length; i++)
            {
                Console.Write(MyArray[i]+"\t");
            }

            Console.WriteLine();

            //Использование функции

            Console.Write("Введите искомое число: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(FindIndex(MyArray, number));

            Console.ReadKey();


        }
    }
}
