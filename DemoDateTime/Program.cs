using System;

namespace DemoDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            var now = DateTime.Now;
            var today = DateTime.Today;

            var tommorow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd"));
        }
    }
}
