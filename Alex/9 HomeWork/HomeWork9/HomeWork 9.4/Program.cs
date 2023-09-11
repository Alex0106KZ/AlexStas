using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_9._4
{
    internal class Program

    {

        static void DeleteIndex(ref int[] arr, int index)
        {
            int[] NewArray = new int[arr.Length-1];

            for (int i = 0; i < index; i++)
            {
                NewArray[i] = arr[i];
            }

            for (int i = index; i < NewArray.Length; i++)
            {
                NewArray[i] = arr[i+1];
            }

            arr = NewArray;

        }
        static void Main(string[] args)
        {
            int[] MyArray = { 1, 2, 3, 4, 5, 6, 7, 8, };

            Console.WriteLine("Введите индекс элемента, который нужно удалить: ");
            int index = int.Parse(Console.ReadLine());

            DeleteIndex(ref MyArray, index);

            Console.ReadKey();
        }
    }
}
