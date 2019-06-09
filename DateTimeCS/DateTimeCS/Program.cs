using System;
using System.Threading;

namespace DateTimeCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(1995, 12, 4);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine(dateTime.ToLongDateString());
            Console.WriteLine(now);
            Console.WriteLine(today);
            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);
            Console.WriteLine("Tomorrow: " + now.AddDays(1));
            Console.WriteLine("Yesterday: " + now.AddDays(-1));
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());

            Console.WriteLine(now.ToString("R"));

            // Creating
            var timeSpan = new TimeSpan(1,2,3);
            var timeSpan1 = new TimeSpan(1,0,0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            //Thread.Sleep(3000);
            var end = DateTime.Now.AddMinutes(2);

            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            // properties
            Console.WriteLine("Minute: " + timeSpan.Minutes);
            Console.WriteLine("Total Minute: " + timeSpan.TotalMinutes);

            // Add
            Console.WriteLine("Add example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // ToString

            Console.WriteLine("ToString example: " + timeSpan.ToString());

            // Parse
            Console.WriteLine("Parse example: " + TimeSpan.Parse("01:02:03"));

            
        }
    }
}