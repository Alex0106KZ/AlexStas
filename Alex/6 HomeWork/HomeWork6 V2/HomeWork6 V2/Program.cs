using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#1 Определение длинны массива
            Console.Write("Задайте длинну массива: ");
            int ArraySize = int.Parse(Console.ReadLine());

            //#2 Инициализация массива
            int[] MyArray = new int[ArraySize];

            //#3 Заполнение элементов массива с клавиатуры
            for (int i = 0; i < ArraySize; i++) 
            {
                Console.Write("Введите " + (i+1) + " элемент массива: ");
                MyArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();    

            //#4 Вывод введенного массива
            Console.Write("Введенный массив: [ ");
            for (int i = 0; i < MyArray.Length; i++)
                Console.Write(MyArray[i] + " ");

            Console.WriteLine("]\n");

            //#5Сортировка массива по возрастанию 

            int[] increaseArray = MyArray.OrderBy(i => i).ToArray();
            Console.Write("Сортировка массива по возрастанию: [ ");
            for (int i = 0; i < increaseArray.Length; i++)
                Console.Write(increaseArray[i] + " ");
            Console.WriteLine("]\n");

            //#6Сортировка массива по убыванию

            int[] descendArray = MyArray.OrderByDescending(i => i).ToArray();
            Console.Write("Сортировка массива по убыванию: [ ");
            for (int i = 0; i < descendArray.Length; i++)
                Console.Write(descendArray[i] + " ");
            Console.WriteLine("]\n");

            //#7 Вывод массива в обратном порядке

            int [] ReverseArray = MyArray.Reverse().ToArray();

            Console.Write("Масив в обратном порядке: [ ");
            
            for (int i = 0; i < ReverseArray.Length; i++)
                Console.Write(ReverseArray[i] + " ");
                
            Console.WriteLine("]\n");

            //#7 Сумма четных чисел в массиве

            int evenSum = MyArray.Where(i => i % 2 == 0).Sum();
            Console.WriteLine("Сумма четных чисел в массиве: " + evenSum + "\n");

            //#9 Нименьшее число в массиве
            Console.WriteLine("Наименьшее число в массиве: " + MyArray.Min() + "\n");

            //#10 Наибольшее число в массиве
            Console.WriteLine("Наибольшее число в массиве: " + MyArray.Max());

            Console.ReadKey();

        }
    }
}
