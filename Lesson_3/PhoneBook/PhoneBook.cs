using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phoneBook = new string[5, 2];
            phoneBook[0, 0] = "Иванов И.И. - ";
            phoneBook[1, 0] = "Петров А.К. - ";
            phoneBook[2, 0] = "Васин В.Д. - ";
            phoneBook[3, 0] = "Белов Ф.М. - ";
            phoneBook[4, 0] = "Михайлов Д.С. - ";
            phoneBook[0, 1] = "+7(999)485-23-51";
            phoneBook[1, 1] = "+7(999)654-93-10";
            phoneBook[2, 1] = "+7(999)781-21-87";
            phoneBook[3, 1] = "+7(999)349-45-04";
            phoneBook[4, 1] = "+7(999)938-12-47";

            for (int i = 0; i < phoneBook.GetLength(0); i++)
            {
                for (int j = 0; j < phoneBook.GetLength(1); j++)
                {
                    Console.Write(phoneBook[i, j] );
                }
                Console.WriteLine();
            }

            
            Console.ReadKey();
        }
    }
}
