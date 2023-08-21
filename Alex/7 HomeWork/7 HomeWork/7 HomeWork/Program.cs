using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Задание размера массивов

            Console.Write("Введите количество строк массива: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов массива: ");
            int height = int.Parse(Console.ReadLine());

            //Инициализация массивов

            int[,] MyArray1 = new int[height, width];
            int[,] MyArray2 = new int[height, width];
            int[,] MyArray3 = new int[height, width];

            //Заполнение 1-го массива с клавиатуры

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("Элемент[" + i + "," + j + "]: ");
                    MyArray1[i, j] = int.Parse(Console.ReadLine());
                }      
            }

            //Заполнение 2-го массива случайными числами

            Random random = new Random();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    MyArray2[i, j] = random.Next(100);
                }
            }

            //Сложение чисел 1-го и 2-го массивов

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    MyArray3[i, j] = MyArray1[i, j] + MyArray2[i, j];
                    
                }
            }

            //Вывод в консоль 1-го массива

            Console.Clear();

            Console.WriteLine("Массив введенный с клавиатуры: ");

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(MyArray1[i, j] + "\t");

                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            //Вывод на консоль 2-го массива

            Console.WriteLine("Массив сгенерированный случайно: ");

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(MyArray2[i, j] + "\t");

                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            //Вывод на консоль 3-го массива

            Console.WriteLine("Массив в котором элементы это сумма элементов прошлых 2-х массивов: ");
            Console.WriteLine("Четные числа помечены знаком <*>");

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {

                    if (MyArray3[i, j] % 2 == 0)
                        Console.Write(MyArray3[i, j] + "*" +"\t");
                    else
                        Console.Write(MyArray3[i, j] + "\t");

                }
                Console.WriteLine();
            }

            Console.ReadKey();









        }
    }
}
