using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_6
{
    public class Employee
    {
        
        
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string TelNumber { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }

        public Employee(/*string name, string pos, string email, string tel, int sal, int age*/)
        {
            //Name = name;
            //Position = pos;
            //Email = email;
            //TelNumber = tel;
            //Salary = sal;
            //Age = age;
        }
        public static List<Employee> SelectEmployee(Employee[] empArray)
        {
            List<Employee> empList = new List<Employee>();    
            for (int i = 0; i < empArray.Length; i++)
            {
                if (empArray[i].Age > 40)
                {
                    empList.Add(empArray[i]);
                }
                else
                {
                    Console.WriteLine("Нет сотрудника старше 40 лет");
                }
            }
            return empList;
        }
    }

}


