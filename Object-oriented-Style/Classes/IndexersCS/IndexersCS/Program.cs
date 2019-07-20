using System;

namespace IndexersCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Anuwat";

            Console.WriteLine(cookie["name"]);
        }
    }
}
