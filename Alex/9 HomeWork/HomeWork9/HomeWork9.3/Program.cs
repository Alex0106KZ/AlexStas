using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9._3
{
    internal class Program
    {


        static void Insert(ref int[] arr, int index, int amount)
        {
            
            int[] NewArray = new int[arr.Length+1];

            NewArray[index] = amount; 

            for (int i = 0; i < index;i++)
                NewArray[i] = arr[i];

            for (int i = index+1; i < NewArray.Length; i++)
                NewArray[i] = arr[i-1];

            arr = NewArray;

        }

        static void Main(string[] args)
        {
            int[] MyArray = { 1, 2, 3, 4, 5, 6, 7, 8, };

            Console.Write("Укажите число которое нужно вставить: ");
            int amount = int.Parse(Console.ReadLine());

            Console.Write("Укажите индекс: ");
            int index = int.Parse(Console.ReadLine());

            Insert(ref MyArray, index, amount);

            Console.ReadKey();

        }
    }
}
