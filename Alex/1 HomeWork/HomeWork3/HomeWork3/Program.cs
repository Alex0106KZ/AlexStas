using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Конвертер валют KRW в KZT-----");
            Console.Write("Введите сумму в KRW: ");
            Double KRW = System.Convert.ToDouble(Console.ReadLine());

            Double Result = KRW / 2.95;
            

            Console.WriteLine(KRW + " KRW = " + Math.Round(Result, 4) + " KZT");
            Console.ReadKey(); 
        }
    }
}
