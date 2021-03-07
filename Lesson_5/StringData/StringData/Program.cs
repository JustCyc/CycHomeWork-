using System;
using System.IO;

namespace StringData
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "text.txt";
            File.WriteAllText(fileName, Console.ReadLine());

            string fileText = File.ReadAllText(fileName);
            Console.WriteLine(fileText);
            Console.ReadKey();
        }
    }
}
