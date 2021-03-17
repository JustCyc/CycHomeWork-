using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_7
{
    class Cross
    {
        public static int SIZE_X = 3;
        public static int SIZE_Y = 3;

        static char[,] field = new char[SIZE_Y, SIZE_X];

        public static char PLAYER_DOT = 'X';
        public static char AI_DOT = 'O';
        public static char EMPTY_DOT = '.';

        static Random random = new Random();

        public static void InitField()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    field[i, j] = EMPTY_DOT;
                }
            }
        }

        public static void PrintField()
        {
            Console.Clear();
            Console.WriteLine("-------");
            for (int i = 0; i < SIZE_Y; i++)
            {
                Console.Write("|");
                for (int j = 0; j < SIZE_X; j++)
                {
                    Console.Write(field[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------");
        }

        public static void SetSym(int y, int x, char sym)
        {
            field[y, x] = sym;
        }

        public static bool IsCellValid(int y, int x)
        {
            if (x < 0 || y < 0 || x > SIZE_X - 1 || y > SIZE_Y - 1)
            {
                return false;
            }

            return field[y, x] == EMPTY_DOT;
        }

        public static bool IsFieldFull()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    if (field[i, j] == EMPTY_DOT)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static void PlayerStep()
        {
            int x;
            int y;
            do
            {
                Console.WriteLine($"Введите координаты X Y (1-{SIZE_X})");
                x = Int32.Parse(Console.ReadLine()) - 1;
                y = Int32.Parse(Console.ReadLine()) - 1;
            } while (!IsCellValid(y, x));
            SetSym(y, x, PLAYER_DOT);
        }

        public static void AiStep()
        {
            int x;
            int y;
            do
            {
                x = random.Next(0, SIZE_X);
                y = random.Next(0, SIZE_Y);
            } while (!IsCellValid(y, x));
            SetSym(y, x, AI_DOT);
        }

        public static bool CheckWin(char sym)
        {
            if (field[0, 0] == sym && field[0, 1] == sym && field[0, 2] == sym)
            {
                return true;
            }
            if (field[1, 0] == sym && field[1, 1] == sym && field[1, 2] == sym)
            {
                return true;
            }
            if (field[2, 0] == sym && field[2, 1] == sym && field[2, 2] == sym)
            {
                return true;
            }

            if (field[0, 0] == sym && field[1, 0] == sym && field[2, 0] == sym)
            {
                return true;
            }
            if (field[0, 1] == sym && field[1, 1] == sym && field[2, 1] == sym)
            {
                return true;
            }
            if (field[0, 2] == sym && field[1, 2] == sym && field[2, 2] == sym)
            {
                return true;
            }

            if (field[0, 0] == sym && field[1, 1] == sym && field[2, 2] == sym)
            {
                return true;
            }
            if (field[2, 0] == sym && field[1, 1] == sym && field[0, 2] == sym)
            {
                return true;
            }

            return false;
        }
    }
}

       