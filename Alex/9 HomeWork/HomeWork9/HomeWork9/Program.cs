using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    internal class Program
    {

        static void Resize<T> (ref T[] arr, uint newSize)
        {


           T[] NewArray = new T[newSize];

            
            //Более короткое решение

            for (int i = 0; i < arr.Length && i < newSize ; i++)
            {
                NewArray[i] = arr[i];
            }

            arr = NewArray;
            
            //Более длинное решение
            //if (arr.Length < newSize)
            //{


            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        NewArray[i] = arr[i];
            //    }
            //}
            //else
            //{
                    
            //   for (int i = 0;i < newSize; i++)
            //    {
            //        NewArray[i] = arr[i];
            //    }

            //}

            //arr = NewArray;

                
        }
        static void Main(string[] args)
        {
            int[] MyArray = {1, 2, 3, 4, 5};

            Console.WriteLine("Укажите новое количество элементов: ");
            uint NewSize = uint.Parse(Console.ReadLine());

            Resize(ref MyArray, NewSize);

            Console.ReadKey();
        }
    }
}
