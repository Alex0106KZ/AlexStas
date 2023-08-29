using System;
using System.Globalization;

namespace convertValut
{
    class Program
    {
        static void Main(string[] args)
        {
            double dollar, euro, rubl, tenge1;
            string tenge;
            dollar = 434.3;
            euro = 478.4;
            rubl = 4.99;

            Console.WriteLine("Введите сюда сколько у вас есть теньгов!!!");
            tenge = Console.ReadLine();
            tenge1 = Convert.ToDouble(tenge);

            double dollarkurs = tenge1 / dollar;
            double eurokurs = tenge1 / euro;
            double rublkurs = tenge1 / rubl;

            Console.WriteLine("вот столько долларов = " + dollarkurs + " Вот столько евро = " + eurokurs + " Вот столько рубля = " + rublkurs);
        }
    }
}

