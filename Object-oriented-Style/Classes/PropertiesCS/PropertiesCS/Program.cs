using System;

namespace PropertiesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1995, 12, 04));
            //person.Birthdate = new DateTime(1995,12,04);
            Console.WriteLine("Your birthdate is {0}", person.Age);
        }
    }
}
