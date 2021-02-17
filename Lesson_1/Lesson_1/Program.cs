using System;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            DateTime date = DateTime.Now;

            Console.WriteLine("Введите имя пользователя:");
            name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня {date}");
            Console.ReadKey();
        }
    }
}
