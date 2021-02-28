using System;

namespace stringSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел");
            string numbers = Console.ReadLine();
            Console.WriteLine($"Сумма чисел в строке = {stringSum(numbers)}");

            Console.ReadKey();
        }

        static int stringSum(string numbers)
        {
            int sum = 0;
            string[] number = numbers.Split(' ');
            foreach (var num in number)
            {
                if(num == " " || num == "")
                {

                }
                else
                {
                    sum = sum + int.Parse(num);
                }
            }
            return sum;
        }
    }
}
