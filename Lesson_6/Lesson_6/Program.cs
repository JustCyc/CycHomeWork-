using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание с массивом 
            string[,] array = new string[4, 4];
            array[0, 0] = array[1, 2] = array[3, 0] = array[3, 2] = "1";
            array[0, 1] = array[1, 3] = array[2, 0] = array[2, 1] = "2";
            array[0, 3] = array[1, 0] = array[2, 2] = array[3, 3] = "3";
            array[0, 2] = array[2, 3] = array[3, 1] = "4";
            array[1, 1] = "find me";
            try
            {
                Console.WriteLine(ArrayException.ConvertAndSum(array));
            }
            catch(ArrayException.MyArraySizeException)
            {
                Console.WriteLine(" Неверный входной размер массива\n");
            }
            catch(ArrayException.MyArrayDataException)
            {
                Console.WriteLine(" Неверный тип ячейки массива\n");
            }


            //Employee[] empArray = new Employee[5];
            //for (int i = 0; i < empArray.Length; i++)
            //{
            //    empArray[i] = new Employee("Иванов", "кто", "e", "123", 1200, 30);
            //    empArray[i] = new Employee("Иванов", "кто", "e", "123", 1200, 20);
            //    empArray[i] = new Employee("Иванов", "кто", "e", "123", 1200, 40);
            //    empArray[i] = new Employee("Иванов", "кто", "e", "123", 1200, 45);
            //    empArray[i] = new Employee("Иванов", "кто", "e", "123", 1200, 32);
            //}
            //Console.WriteLine(Employee.SelectEmployee(empArray));



                Console.ReadKey();
        }
    }
}
