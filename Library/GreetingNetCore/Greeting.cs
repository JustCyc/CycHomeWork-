using System;
using System.Collections.Generic;
using System.Text;

namespace GreetingNetCore
{
    public class Greeting
    {
        public static void HelloMate()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine($" Hello mate, the time is now {date}");
        }
    }
}
