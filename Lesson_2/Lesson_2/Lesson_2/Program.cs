using System;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Первое задание по поиску средней температуры 

            Console.WriteLine("Введите минимальную и максимальную температуру за сутки: ");
            float t_min = float.Parse(Console.ReadLine());
            float t_max = float.Parse(Console.ReadLine());
            float t_mid = (t_min + t_max) / 2;
            Console.WriteLine($"Средняя температура за день равна {t_mid}\n");

            // Второе задание по выводу номера месяца 

            Console.WriteLine("Введите порядковый номер месяца");
            int num_month = int.Parse(Console.ReadLine());
            switch (num_month)
            {
                case 1: Console.WriteLine(Month.Январь); break;
                case 2: Console.WriteLine(Month.Февраль); break;
                case 3: Console.WriteLine(Month.Март); break;
                case 4: Console.WriteLine(Month.Апрель); break;
                case 5: Console.WriteLine(Month.Май); break;
                case 6: Console.WriteLine(Month.Июнь); break;
                case 7: Console.WriteLine(Month.Июль); break;
                case 8: Console.WriteLine(Month.Август); break;
                case 9: Console.WriteLine(Month.Сентябрь); break;
                case 10: Console.WriteLine(Month.Октябрь); break;
                case 11: Console.WriteLine(Month.Ноябрь); break;
                case 12: Console.WriteLine(Month.Декабрь); break;
                default: Console.WriteLine("Введен неверный номер"); break;
            }

            // Третье задание чётное/нечётное 

            if (num_month % 2 == 0)
            {
                Console.WriteLine("\nВведено чётное число");
            }
            else
            {
                Console.WriteLine("\nВведено нечётное число");
            }

            // Вывод сообщения, если температура > 0 и зимний месяц

            if (num_month == 12 || num_month == 1 || num_month == 2)
            {
                if (t_mid > 0)
                {
                    Console.WriteLine("\nДождливая зима");
                }
            }

            // Вывод чека 

            int num = 773289;
            DateTime time = DateTime.Now;
            string shop = "Продуктовый магазин";
            string cashier = "Иванов И.И.";
            double sum = 1042.77;
          
            Console.WriteLine($"\n Магазин '{shop}'\n Чек №{num}\n Дата покупки: {time}\n Кассир: {cashier}\n Сумма покупки: {sum} рублей\n");

            // Шестое задание - расписание работы офисов 

            Schedule office_1 = Schedule.Понедельник | Schedule.Вторник | Schedule.Среда | Schedule.Четверг | Schedule.Пятница;
            Schedule office_2 = Schedule.Среда | Schedule.Четверг | Schedule.Пятница | Schedule.Суббота | Schedule.Воскресенье;
            Schedule office_3 = Schedule.Понедельник | Schedule.Среда | Schedule.Пятница | Schedule.Воскресенье;
            
            Console.WriteLine("Введите число от 1 до 3, чтобы выбрать расписание офиса");
            byte office_num = byte.Parse(Console.ReadLine());
            switch (office_num)
            {
                case 1: Console.WriteLine($"Время работы первого офиса: {office_1}"); break;
                case 2: Console.WriteLine($"Время работы второго офиса: {office_2}"); break;
                case 3: Console.WriteLine($"Время работы третьего офиса: {office_3}"); break;
                default: Console.WriteLine("Введен неверный номер"); break;
            }


            Console.ReadKey();

        }

        // Месяцы 
        enum Month
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }
        // Расписание 
        [Flags]
        enum Schedule
        {
            Понедельник = 0b_0000001,
            Вторник = 0b_0000010,
            Среда = 0b_0000100,
            Четверг = 0b_0001000,
            Пятница = 0b_0010000,
            Суббота = 0b_0100000,
            Воскресенье = 0b_1000000

        }

    }
}
