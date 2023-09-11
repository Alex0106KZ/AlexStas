using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nulleble
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int? a = null;

            int b = 5;

            int result = 0;

            //Обработка через оператор null объединения

            int NullResult = (a ?? 0) + b;

            Console.WriteLine( $"NullResult {NullResult}");


            //Обработка через If (воняет гавной)

            if (a.HasValue)
                result = a.Value + b;
            else
                result = b;

            //Обработка с помощью метода  GetValueOrDefault

            int result2 = a.GetValueOrDefault(20) + b;


            Console.WriteLine(result);
            Console.WriteLine(result2);

            Console.ReadKey();
        }
    }
}
