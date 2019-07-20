using System;

namespace ClassesCS
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0} I am {1}", to, this.Name);
        }

        public static Person Parse(string personName)
        {
            Person person = new Person();
            person.Name = personName;
            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person anuwatPerson = Person.Parse("Anuwat");
            Person pansaPerson = Person.Parse("Pansa");
            anuwatPerson.Introduce("Pansa");
            pansaPerson.Introduce("Anuwat");
        }
    }
}