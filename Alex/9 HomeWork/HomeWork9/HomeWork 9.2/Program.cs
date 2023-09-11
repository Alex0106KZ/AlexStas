using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_9._2
{
    internal class Program
    {

        static void AddElement<T>(ref T[] arr, uint position, uint amount, uint choosenPosition)

        {
            //Добавление пустых элементов массива

            T[] newArray = new T [arr.Length + amount];

            if (position == 1)
            {
                for (uint i = amount; i < newArray.Length ; i++)
                {
                    newArray[i] = arr[i-amount];
                }
            }

            else if (position == 2) 
            {   
                for (uint i = 0; i < choosenPosition; i++)
                {
                    newArray[i] = arr[i];   
                }

                for (uint i = choosenPosition+amount; i < newArray.Length ; i++)
                {
                    newArray[i] = arr[i-amount];
                }

            }

            else if (position == 3)
            {
                for (int i = 0; i < arr.Length ;i++)
                {
                    newArray[i] = arr[i];
                }
            }
            

            arr = newArray;

        }

        static void Main(string[] args)
        {
            int[] MyArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Console.Write("Введите количество элекментов, которое надо добавить: ");
            uint amount = uint.Parse(Console.ReadLine());

            Console.Write("Укажите, где добавить(1 - в начале, 2 - по индексу, 3 - в конце)");
            uint position  = uint.Parse(Console.ReadLine());

            uint choosenPosition = 0;


            if (position == 2)
            {
                Console.Write("Введите индекс элемента, куда будут добавлены новые элементы: ");
                choosenPosition = uint.Parse(Console.ReadLine());
            }    
                

            AddElement(ref MyArray, position, amount, choosenPosition);

            Console.ReadKey();

        }
    }
}
