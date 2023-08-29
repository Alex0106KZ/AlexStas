using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myStr = null;

            Console.WriteLine(myStr ??= "Нет строки");

            Console.ReadKey();
        }
    }
}
