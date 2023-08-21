using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_HomeWork
{
    internal class Program
    {

        static void CreateLine(string chr, uint amount)
        {
            for (int i = 0; i < amount; i++) 
            {
                Console.Write(chr);
            }
        }

       
        

        static void Main(string[] args)
        {
            Console.Write("Введите символ: ");
            string chr = Console.ReadLine();

            Console.Write("Введите количество символов: ");
            uint amount = uint.Parse(Console.ReadLine());
            

            CreateLine(chr, amount);

            Console.ReadKey();
        }
    }
}
