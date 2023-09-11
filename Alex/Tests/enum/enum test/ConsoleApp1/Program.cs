using System;

namespace enum_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[4] { 20, 25, 30, 35 };
            int[] y = new int[4] { 20, 20, 20, 20 };
            ConsoleKey EnteredKey = ConsoleKey.Enter;

            while (EnteredKey != ConsoleKey.P)
            {
                EnteredKey = Console.ReadKey().Key;

                for (int i = 3; i > 0; i--)
                {
                    x[i] = x[i - 1];
                    y[i] = y[i - 1];
                }

                switch (EnteredKey)
                {
                    case ConsoleKey.UpArrow:
                        y[0]--;
                        break;
                    case ConsoleKey.DownArrow:
                        y[0]++;
                        break;
                    case ConsoleKey.RightArrow:
                        x[0]++;
                        break;
                    case ConsoleKey.LeftArrow:
                        x[0]--;
                        break;
                }

                Console.Clear();

                for (int i = 0; i < 4; i++)
                {
                    Console.SetCursorPosition(x[i], y[i]);
                    Console.Write("*");
                }
            }
        }
    }
}