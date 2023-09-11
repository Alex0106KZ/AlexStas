using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Snake
{
    internal class Program
    {


        /// <summary>
        /// Выводит на экран строки олномерного массива, из которых слодится картинка
        /// </summary>
        /// <param name="PictureArray">Передайте сюда массив, в котором картинка из строк</param>
        /// <param name="CorrectX">На сколько сдвинуть изображение вправо</param>
        /// <param name="CorrectY">На сколько сдвинуть изображение вниз</param>

        static void Draw2DPicture(string[] PictureArray, int CorrectX, int CorrectY)
        {
            for (int i = 0; i < PictureArray.Length; i++)
            {
                Console.SetCursorPosition(CorrectX, i + CorrectY);
                Console.WriteLine(PictureArray[i]);
            }
        }


        


        static void Main(string[] args)
        {

           

            

            Stopwatch stopwatch = new Stopwatch();

            Random foodRandom = new Random();

            int Score = 0;
            bool isItFirstGame = true;

            int foodX = foodRandom.Next(1, 86);
            int foodY = foodRandom.Next(1, 26);

            //Инициализация массива, содержащего рамку

            string[,] border =
            {
                {"#######################################################################################"},
                {"#                                                                                     #"},
                {"#                                                                                     #"},
                {"#                                                                                     #"},
                {"#                                                                                     #"},
                {"#                                                                                     #"},
                {"#                                                                                     #"},
                {"#                                                                                     #"},
                {"#                                                                                     #"},
                {"#                                                                                     #"},
                {"#                                                                                     #"},
                {"#                                                                                     #"},
                {"#                                                                                     #"},
                {"#                                                                                     #"},
                {"#                                                                                     #"},
                {"#                                                                                     #"},
                {"#                                                                                     #"},
                {"#                                                                                     #"},
                {"#                                                                                     #"},
                {"#                                                                                     #"},
                {"#                                                                                     #"},
                {"#                                                                                     #"},
                {"#                                                                                     #"},
                {"#                                                                                     #"},
                {"#                                                                                     #"},
                {"#                                                                                     #"},
                {"#######################################################################################"}
            };

            //Инициализация массива, содержащего надпись "Вы проиграли"

            string[] YouLose =
            {
                "████──█───█────████─████─████─█──█─███─████─████───██─█──█",
                "█──██─█───█────█──█─█──█─█──█─█──█─█───█──█─█──█──█─█─█──█",
                "████──███─█────█──█─████─█──█─█─██─█───████─████─█──█─█─██",
                "█──██─█─█─█────█──█─█────█──█─██─█─█───█────█──█─█──█─██─█",
                "████──███─█────█──█─█────████─█──█─█───█────█──█─█──█─█──█",
                "                                                          ",
                "            Начать сначала? (Y - Да,   N - Нет)           "
            };

            //Инициализация массива, содержащего надпись "Змейка"

            string[] Logo =
          {
                 "   ───────────────██───────────" ,
                 "   ███─█───█─███─█──█─█──█─████" ,
                 "   ──█─██─██─█───█──█─█─█──█──█" ,
                 "   ███─█─█─█─███─█─██─██───████" ,
                 "   ──█─█───█─█───██─█─█─█──█──█" ,
                 "   ███─█───█─███─█──█─█──█─█──█" ,
                 "                              "  ,
                "Нажмите любую клавишу, чтобы начать" 
            };

            

            //Вывод лого

            Draw2DPicture(Logo,45, 10);

           
            

            bool isDead = false;
            ConsoleKey OldKey = ConsoleKey.RightArrow;
            ConsoleKey NewKey = ConsoleKey.RightArrow;

          

            ConsoleKey RestartButton = ConsoleKey.Y;
            
            Sosok: 
            while (RestartButton == ConsoleKey.Y)
            {

                // Начальные координаты змейки
                int[] x = { 20, 21, 22, 23 };
                int[] y = { 20, 20, 20, 20 };
                RestartButton = ConsoleKey.P;

                Score = 0;
                stopwatch.Reset(); 

                isDead = false;
                

                while (isDead == false)
                {



                    //Запускаем секундомер
                    stopwatch.Start();

                    if (isItFirstGame == true)
                        NewKey = Console.ReadKey().Key;
                    else
                    {
                        OldKey = ConsoleKey.RightArrow;
                        NewKey = ConsoleKey.RightArrow;
                        isItFirstGame = true;
                    }

                    //Запрещаем змейке ползти в обратном направлении
                    if (OldKey == ConsoleKey.LeftArrow && NewKey == ConsoleKey.RightArrow)
                        NewKey = ConsoleKey.LeftArrow;
                    else if (OldKey == ConsoleKey.RightArrow && NewKey == ConsoleKey.LeftArrow)
                        NewKey = ConsoleKey.RightArrow;
                    else if (OldKey == ConsoleKey.UpArrow && NewKey == ConsoleKey.DownArrow)
                        NewKey = ConsoleKey.UpArrow;
                    else if (OldKey == ConsoleKey.DownArrow && NewKey == ConsoleKey.UpArrow)
                        NewKey = ConsoleKey.DownArrow;


                    //Нельзя нажимать ничего кроме стрелочек
                    if (NewKey == ConsoleKey.LeftArrow || NewKey == ConsoleKey.RightArrow || NewKey == ConsoleKey.UpArrow || NewKey == ConsoleKey.DownArrow)
                        OldKey = NewKey;
                    else
                        NewKey = OldKey;


                    while (OldKey == NewKey)
                    {


                        OldKey = NewKey;


                        //Сдвиг элементов массива

                        for (int i = 0; i <= x.Length - 2; i++)
                        {
                            x[i] = x[i + 1];
                            y[i] = y[i + 1];
                        }

                        //Обработка нажатий стрелочек

                        switch (OldKey)
                        {
                            case ConsoleKey.LeftArrow:
                                x[x.Length - 1]--;
                                break;

                            case ConsoleKey.RightArrow:
                                x[x.Length - 1]++;
                                break;

                            case ConsoleKey.UpArrow:
                                y[x.Length - 1]--;
                                break;

                            case ConsoleKey.DownArrow:
                                y[x.Length - 1]++;
                                break;
                        }

                        Console.Clear();

                        //Вывод массива, содержащего рамку

                        for (int i = 0; i < border.GetLength(0); i++)
                        {
                            for (int j = 0; j < border.GetLength(1); j++)
                            {
                                Console.Write(border[i, j]);
                            }
                            Console.WriteLine();
                        }

                        //Вывод статистики

                        TimeSpan ts = stopwatch.Elapsed;
                        Console.SetCursorPosition(90, 4);
                        Console.Write($"Вы продержались: {ts.Minutes}:{ts.Seconds}");
                        Console.SetCursorPosition(90, 5);
                        Console.Write($"Счет: {Score}");




                        //Отрисовка змейки

                        for (int i = 1; i < x.Length; i++)
                        {

                            Console.SetCursorPosition(x[i], y[i]);
                            if (i == x.Length - 1)
                                Console.Write("e");
                            else
                                Console.Write("*");

                        }


                        //Проверка касания головы змейки со стеной

                        if (border[y[y.Length - 1], 0][x[x.Length - 1]] == '#')
                        {


                            stopwatch.Stop();
                            isDead = true;

                            isItFirstGame = false;

                            Draw2DPicture(YouLose, 15, 10);


                            
                           RestartButton = Console.ReadKey().Key;
                           break;
                        }

                        //Проверка касания змейки со своим телом

                        for (int i = 0; i < x.Length - 1; i++)
                        {
                            if (x[x.Length - 1] == x[i] && y[x.Length - 1] == y[i])
                            {



                                stopwatch.Stop();
                                isDead = true;

                                isItFirstGame = false;

                                Draw2DPicture(YouLose, 15, 10);
                                RestartButton = Console.ReadKey().Key;


                                goto Sosok;
                            }

                        }

                        //Проверка касания головы змейки с едой
                        


                        if (x[x.Length - 1] == foodX && y[x.Length - 1] == foodY)
                        {
                            //Создание новой еды в случайном месте
                            foodX = foodRandom.Next(1, 86);
                            foodY = foodRandom.Next(1, 26);
                            Console.SetCursorPosition(foodX, foodY);
                            Console.Write("@");

                            Score++;

                            //Увеличение змейки

                            Array.Resize(ref x, x.Length + 1);
                            Array.Resize(ref y, y.Length + 1);

                            x[x.Length - 1] = x[x.Length - 2];
                            y[x.Length - 1] = y[x.Length - 2];

                        }

                        else
                        {
                            Console.SetCursorPosition(foodX, foodY);
                            Console.Write("@");
                        }

                        //Замедление выполнения цикла
                        System.Threading.Thread.Sleep(100);

                        if (Console.KeyAvailable)
                            break;







                    }
                }
            }
        }






    }
}
