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


            Employee[] empArray = new Employee[5];
            for (int i = 0; i < empArray.Length; i++)
            {
                empArray[i] = new Employee();
                empArray[i].Name = Console.ReadLine();
                empArray[i].Position = Console.ReadLine();
                empArray[i].Email = Console.ReadLine();
                empArray[i].TelNumber = Console.ReadLine();
                empArray[i].Salary = int.Parse(Console.ReadLine());
                empArray[i].Age = int.Parse(Console.ReadLine());
            }

            List<Employee> employeeList = new List<Employee>(Employee.SelectEmployee(empArray));
            foreach (Employee property in employeeList)
            {
                Console.WriteLine($" Имя работника: {property.Name}\n " +
                    $"Должность: {property.Position}\n " +
                    $"Email: {property.Email}\n " +
                    $"Телефонный номер: {property.TelNumber}\n " +
                    $"Зарплата: {property.Salary}\n " +
                    $"Возраст: {property.Age}");
            }


            Console.ReadKey();
        }
    }
}
