using System;
using System.IO;
using System.Collections.Generic;

namespace binFile
{
    class Program
    {
        static void Main(string[] args)
        {
            List<byte> byteList = new List<byte>();
            Console.WriteLine("Введите числа от 0 до 255 через пробел\n");
            string numbers = Console.ReadLine();
            string[] number = numbers.Split(' ');

            // Ради интереса через список реализовал

            foreach (var num in number)
            {
                if (num == " " || num == "")
                {

                }
                else
                {
                    byte numByte = byte.Parse(num);
                    byteList.Add(numByte);
                }
            }
            byte[] numArray = new byte[byteList.Count];
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = byteList[i];
            }
            File.WriteAllBytes("bytes.bin", numArray);

            byte[] fromFile = File.ReadAllBytes("bytes.bin");
            foreach (byte b in fromFile)
            {
                Console.WriteLine($"\n{b.ToString()}");
            }
            Console.ReadKey();
        }
    }
}