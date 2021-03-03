using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Program
    {

        static void Main(string[] args)
        {
            char[,] field = new char[11,11];
            Random rnd = new Random();

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    
                }
            }
            

            // создание и отрисовка поля без кораблей
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = 'O';
                    if (field[i, j] == 'O')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    
                    field[i, 0] = '|';
                    field[i, 10] = '|';
                    field[0, j] = '-';
                    field[10, j] = '-';
                    if (field[i, j] == '|' || field[i, j] == '-')
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                    }

                    Console.Write($"{field[i, j]} ");
                    Console.ResetColor(); 
                }
                Console.WriteLine();
            }

            // создание и размещение кораблей 
            
            for (int i = 0; i < 7; i++)
            {
                int rnd_x = rnd.Next(1, 9);
                int rnd_y = rnd.Next(1, 9);

                while (field[rnd_x, rnd_y] != 'O')
                {
                    rnd_x = rnd.Next(1, 9);
                    rnd_y = rnd.Next(1, 9);
                }

                if (field[rnd_x + 1, rnd_y + 1] == 'X' 
                    || field[rnd_x - 1, rnd_y + 1] == 'X' 
                    || field[rnd_x + 1, rnd_y - 1] == 'X' 
                    || field[rnd_x - 1, rnd_y - 1] == 'X'
                    || field[rnd_x, rnd_y + 1] == 'X'
                    || field[rnd_x, rnd_y - 1] == 'X'
                    || field[rnd_x - 1, rnd_y] == 'X'
                    || field[rnd_x + 1, rnd_y] == 'X')
                    {
                    i--; // может привести к бесконечному циклу но не здесь 
                    continue;
                    }
                else
                {
                    field[rnd_x, rnd_y] = 'X';
                }
                
            }

            

            Console.WriteLine("\n После расстановки кораблей\n");
            // вывод поля
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == 'X')
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    if (field[i, j] == 'O')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    if (field[i, j] == '|' || field[i, j] == '-')
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.Write($"{field[i, j]} ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
