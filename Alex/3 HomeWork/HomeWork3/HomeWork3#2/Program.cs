using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Калькулятор двух чисел-----");
            Console.WriteLine("Поддерживаемые операции: \"+\", \"-\", \"*\", \"/\".  ");

            Double FirstValue, SecondValue;
            bool IsNumber1, IsNumber2;
            


            Console.Write("Введите первое число: ");
            if (Double.TryParse(Console.ReadLine(), out FirstValue))              
                    IsNumber1 = true;              
            else              
                    IsNumber1 = false;   
                

            Console.Write("Введите второе число: ");
            if (Double.TryParse(Console.ReadLine(), out SecondValue ))                
                    IsNumber2 = true;                 
            else       
                    IsNumber2 = false;
     
      



            Console.Write("Введите операцию: ");
            string OperationType = Console.ReadLine();

            if (IsNumber1 && IsNumber2) 
                {

                if (OperationType == "+")
                    Console.WriteLine("Результат операции: " + (FirstValue + SecondValue));

                else if (OperationType == "-")
                    Console.WriteLine("Результат операции: " + (FirstValue - SecondValue));

                else if (OperationType == "*")
                    Console.WriteLine("Результат операции: " + (FirstValue * SecondValue));

                else if (OperationType == "/")

                {
                    if (SecondValue != 0)
                        Console.WriteLine("Результат операции: " + (FirstValue / SecondValue));
                    else
                        Console.WriteLine("Обнаружено деление на 0!");
                }
                else
                    Console.WriteLine("Введена некорректная операция!");
                }
            else 
                {
                Console.WriteLine("Введенно не корректное число!");
                }

            Console.ReadKey();
   

        }
    }
}
