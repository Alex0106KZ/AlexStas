using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_HomeWork
{
    internal class Program
    {

        static void PrintArray(int[] arr, int i = 0)
        {
            if (i >= arr.Length)
                return;
            Console.WriteLine(arr[i]);
           

            PrintArray(arr, i+1);
        }
        static void Main(string[] args)
        {
            int[] MyArray = { 1, 2, 3, 4, 5, };
            
            int i = 0;

            PrintArray(MyArray, i);

            Console.ReadKey();
        }
    }
}
