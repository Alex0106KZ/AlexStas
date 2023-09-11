using System;

namespace testParams
{
    internal class Program
    {

        static void TestMethod(int a, int b, bool c = false)
        {
            int intsSum = a+b;

            //for (int i = 0; i < ints.Length; i++)
            //{
            //    intsSum += ints[i];
            //}
            //intsSum = intsSum + a + b;

            if (c)
                Console.WriteLine($"C = True, Сумма ={intsSum}");
            else
                Console.WriteLine($"C = False, Сумма ={intsSum}");

        }
        static void Main(string[] args)
        {
            TestMethod(10,10);
            Console.ReadKey();
        }
    }
}
