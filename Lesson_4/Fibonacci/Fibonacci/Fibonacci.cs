using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int num = int.Parse(Console.ReadLine());
            int fibonacciNumber = FibonacciNum(num);
            Console.WriteLine(fibonacciNumber);
            Console.ReadKey();
        }

         

        static int FibonacciNum(int num)
        {
            if (num == 0 || num == 1)
            {
                return num;
            }
            else
            {
                return FibonacciNum(num - 1) + FibonacciNum(num - 2);
            }      
        }
    }
}
