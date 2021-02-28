using System;

namespace Season
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");
            int month = int.Parse(Console.ReadLine());
            int num_seas = numSeason(month);
            string nameSeason = determSeason(num_seas);
            Console.WriteLine(nameSeason);
            Console.ReadKey();
        }

        static int numSeason(int month)
        {
            int seas = 0;
            if (month == 1 || month == 2 || month == 12)
            {
                seas = 1;// winter
            }
            if (month == 3 || month == 4 || month == 5)
            {
                seas = 2;// spring
            }
            if (month == 6 || month == 7 || month == 8)
            {
                seas = 3;// summer
            }
            if (month == 9 || month == 10 || month == 11)
            {
                seas = 4;// autumn
            }
            return seas;
        }

        static string determSeason(int seas)
        {
            string season = null;
            switch (seas)
            {
                case 1: season = Convert.ToString(Season.Winter); break;
                case 2: season = Convert.ToString(Season.Spring); break;
                case 3: season = Convert.ToString(Season.Summer); break;
                case 4: season = Convert.ToString(Season.Autumn); break;
                default: season = "Error: enter a number from 1 to 12"; break;
            }
            return season;
        }

        enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn 
        }

    }
}
