using System;

namespace FirstAppbyStasyo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int result;
            string str;

            Console.WriteLine("Введите первое число:");
            str = Console.ReadLine();
            a = int.Parse(str);
            Console.WriteLine("Введите второе число:");
            str = Console.ReadLine();
            b = int.Parse(str);

            result = a + b;
            Console.WriteLine("Среднее ариф. = " + result);

        }
    }
}