using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversestr = null;
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();

            // вывод строки в обратной последовательности 
            /*for ( int i = 0; i < str.Length; i++)
            {
                Console.Write(str[(i - str.Length + 1) * (-1)]); 
                
            }*/

            // сохранение обратного массива 
            for (int i = str.Length - 1 ; i >= 0; i--)
            {
                reversestr += (str[i]);
            }
            Console.Write(reversestr);
            Console.ReadKey();
        }
    }
}
