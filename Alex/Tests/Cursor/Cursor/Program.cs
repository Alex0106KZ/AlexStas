using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try 
            {
                Console.Write("Введите ширину: ");
                int width = int.Parse(Console.ReadLine());

                Console.Write("Введите высоту: ");
                int height = int.Parse(Console.ReadLine());

                Console.Clear();

                Console.Write("+");

                for (int i = 0; i < width - 2; i++)
                {
                    Console.Write("-");
                }
                Console.Write("+");

                Console.WriteLine();

                for (int i = 0; i < height; i++)
                {
                    Console.SetCursorPosition(0, i + 1);
                    Console.Write("|");
                    Console.SetCursorPosition(width - 1, i + 1);
                    Console.Write("|");
                }

                Console.SetCursorPosition(0, height);

                Console.Write("+");

                for (int i = 0; i < width - 2; i++)
                {
                    Console.Write("-");
                }
                Console.Write("+");
            }

            catch (Exception) 
            {
                Console.Clear();
                Console.WriteLine("Слишком большой квадрат :(((");            
            }






            Console.ReadKey();
        }
    }
}
