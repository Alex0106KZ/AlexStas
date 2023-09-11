using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1_HomeWork
{
    internal class Program
    {

        static int arraySum(int[] arr, int sum, int i = 0) 
        {
            if (i >= arr.Length)
                return 0;

            return  arr[i] + arraySum(arr, sum, i + 1);




        }

        static void Main(string[] args)
        {

            int sum = 0;
            int[] MyArray = { 1, 1, 1, 2 };

            Console.WriteLine(arraySum(MyArray, sum));

           Console.ReadKey();
            
        }
    }
}
