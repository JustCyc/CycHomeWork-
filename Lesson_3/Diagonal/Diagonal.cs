using System;

namespace Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 5];
            Random rnd = new Random();
            


            // отрисовка массива 
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = rnd.Next(0,10);
                    Console.Write($"{arr[i,j]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nВывод элементов по диагонали\n");
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write($"{arr[i,i]} ");
            }


            Console.ReadKey();
        }
    }
}
