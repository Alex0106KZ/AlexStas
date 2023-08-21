using System;

namespace _6_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1# Заполнение массива с клавиатуры

            Console.Write("Введите длину массива: ");
            int ArraySize = 0;


            try
            {
                ArraySize = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено некорректное число!");
            }

            double[] MyArray = new double[ArraySize];

            for (int i = 0; i < ArraySize; i++)
            {
                Console.Write("Заполните " + (i + 1) + " ячейку массива: ");

                try
                {
                    MyArray[i] = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено некорректное число!");
                }

            }

            Console.Clear();

            Console.WriteLine("Введенная длина массива: " + ArraySize);

            Console.Write("Введенный массив: [ ");
            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.Write(MyArray[i] + " ");
            }
            Console.WriteLine("]");

            //#2 Вывод массива в обратном порядке
            Console.Write("Массив в обратном порядке: [ ");
            for (int i = (MyArray.Length - 1); i >= 0; i--)
            {
                Console.Write(MyArray[i] + " ");
            }
            Console.WriteLine("]");


            //#3 Найти сумму четных чисел в массиве

            double EvenSum = 0;

            for (int i = 0; i < MyArray.Length; i++)
            {

                if (MyArray[i] % 2 == 0)
                {
                    EvenSum += MyArray[i];
                }
            }

            Console.WriteLine("Сумма четных чисел массива: " + EvenSum);

            //#4 Найти наименьшее число в массиве

            double MinNumber = MyArray[0];

            for (int i = 0; i < MyArray.Length; i++)
            {
               MinNumber = MinNumber < MyArray[i] ? MinNumber : MyArray[i];
            }

            Console.WriteLine("Минимальное число в массиве: " + MinNumber);






            Console.ReadKey();
        }
    }
}
