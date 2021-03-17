using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, квадрат которого хотите получить");
            Console.WriteLine($"Результат: {Square.square(int.Parse(Console.ReadLine()))}");
            Console.ReadKey();

            //    Cross.InitField();
            //    Cross.PrintField();

            //    while (true)
            //    {
            //        Cross.PlayerStep();
            //        Cross.PrintField();
            //        if (Cross.CheckWin(Cross.PLAYER_DOT))
            //        {
            //            Console.WriteLine("Player Win!");
            //            break;
            //        }
            //        if (Cross.IsFieldFull())
            //        {
            //            Console.WriteLine("DRAW");
            //            break;
            //        }
            //        Cross.AiStep();
            //        Cross.PrintField();
            //        if (Cross.CheckWin(Cross.AI_DOT))
            //        {
            //            Console.WriteLine("SkyNet Win!");
            //            break;
            //        }
            //        if (Cross.IsFieldFull())
            //        {
            //            Console.WriteLine("DRAW");
            //            break;
            //        }
            //    }
            //    Console.ReadKey();
        }
    }

}
