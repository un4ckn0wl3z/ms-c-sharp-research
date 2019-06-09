using System;

namespace RefAndValTypeCS
{
    public class Person
    {
        public int Age;
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a:{0} b:{1}", a, b));
            var arr1 = new int[3] {1, 2, 3};
            var arr2 = arr1;
            arr2[0] = 0;
            Console.WriteLine(arr1[0]);
            Console.WriteLine(arr2[0]);
            int number = 1;
            Increment(number);
            Console.WriteLine("Inside Main() number is : "+number);

            Person person = new Person(){Age = 20};
            MakeOld(person);
            Console.WriteLine("Inside Main() number is : " + person.Age);
        }

        public static void Increment(int number)
        {
            number += 10;
            Console.WriteLine("Inside Increment() number is : {0} ", number);
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
            Console.WriteLine("Inside MakeOld() number is : {0} ", person.Age);

        }
    }
}