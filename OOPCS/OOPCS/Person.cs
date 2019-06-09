using System;

namespace OOPCS
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is {0} {1}",
                FirstName, LastName);
        }

    }
}