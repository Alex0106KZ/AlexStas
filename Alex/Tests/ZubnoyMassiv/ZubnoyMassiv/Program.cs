using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZubnoyMassiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] MyArray = new int[3][];
            MyArray[0] = new int[3];
            MyArray[1] = new int[7];
            MyArray[2] = new int[4];
            
            Random random = new Random();
            
            for (int i = 0; i < MyArray.Length; i++) 
            {
                for (int j = 0; j < MyArray[i].Length; j++)
                {
                    MyArray[i][j] = random.Next(100);
                }          
            }

            for (int i = 0; i < MyArray.Length; i++)
            {
                for (int j = 0; j < MyArray[i].Length; j++)
                {
                    Console.Write(MyArray[i][j] + "\t");
                }
                Console.WriteLine();
            }

            Console.Write("Введите количество строк массива: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов массива: ");
            int weight = int.Parse(Console.ReadLine());

            int[,] MyArray2 = new int[height,weight];


            for (int i = 0; i < MyArray2.GetLength(0); i++)
            {
                for (int j = 0; j < MyArray2.GetLength(1); j++)
                {
                    MyArray2[i, j] = random.Next(100);
                }
            }

            for (int i = 0; i < MyArray2.GetLength(0); i++)
            {
                for (int j = 0; j < MyArray2.GetLength(1); j++)
                {
                    Console.Write(MyArray2[i, j] + "\t");
                }
                Console.WriteLine();    
            }

            Console.ReadKey();
        }
    }
}
