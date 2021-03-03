using System;

namespace GetFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество пользователей");
            int count = int.Parse(Console.ReadLine());
            string[] nameList = new string[count];
            
            for (int i = 0; i < nameList.Length; i++)
            {
                string Name = GetFullName();
                nameList[i] = Name;
            }
            for (int i = 0; i < nameList.Length; i++)
            {
                Console.WriteLine(nameList[i]);
            }
            Console.WriteLine("\nКонец программы\n");
            Console.ReadKey();
        }

        static string GetFullName()
        {
            Console.WriteLine("\nВведите фамилию");
            string lastName = Console.ReadLine();
            Console.WriteLine("\nВведите имя");
            string firstName = Console.ReadLine();
            Console.WriteLine("\nВведите отчество");
            string patronymic = Console.ReadLine();
            string fullFio = lastName + " " + firstName + " " + patronymic;
            return $"\nВведенное ФИО пользователя - {fullFio}\n";
        }
    }
}

