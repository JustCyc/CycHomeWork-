using System;

namespace GetFullName
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество пользователей для записи ФИО");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(GetFullName());
            }
            Console.WriteLine("\nКонец программы\n");
            Console.ReadKey();
        }

        static string GetFullName()
        {

            Console.WriteLine("Введите фамилию");
            string lastName = Console.ReadLine();
            Console.WriteLine("Введите имя");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите отчество");
            string patronymic = Console.ReadLine();
            string fullFio = lastName + " " + firstName + " " + patronymic;
            return $"\nВведенное ФИО - {fullFio}\n";
        }

    }
}

