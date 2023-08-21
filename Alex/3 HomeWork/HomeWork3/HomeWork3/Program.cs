using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-----Калькулятор двух чисел-----");
                Console.WriteLine("Поддерживаемые операции: \"+\", \"-\", \"*\", \"/\".  ");

                Double a, b;

                try
                {
                    Console.Write("Введите первое число: ");
                    a = Double.Parse(Console.ReadLine());

                    Console.Write("Введите второе число: ");
                    b = Double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Введено некоректное число");
                    Console.ReadKey();  
                    continue;
                }

                Console.Write("Введите операцию: ");
                string c = Console.ReadLine();


                switch (c)
                {

                    case "+":
                        Console.WriteLine("Результат операции: " + (a + b));
                        break;

                    case "-":
                        Console.WriteLine("Результат операции: " + (a - b));
                        break;

                    case "*":
                        Console.WriteLine("Результат операции: " + (a * b));
                        break;
                    case "/":
                        {
                            if (b == 0)
                                Console.WriteLine("Обнаружено деление на ноль!");
                            else
                                Console.WriteLine("Результат операции: " + (a / b));
                        }
                        break;

                    default:
                        Console.WriteLine("Вы ввели неккоректуню операцию");
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}
