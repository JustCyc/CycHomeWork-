using System;
using System.IO;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = DateTime.Now.ToString("HH:mm:ss dd.MMMM.yyyy");
            string fileName = "startup.txt";
            File.WriteAllText(fileName, "При старте программы записывается время запуска\n");
            File.AppendAllText(fileName, $"{time}\n");

            string fileText = File.ReadAllText(fileName);
            Console.WriteLine(fileText);
            Console.ReadKey();
        }


    }
}
