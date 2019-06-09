using System;
using OOPCS.Enum;
using OOPCS.Math;

namespace OOPCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var anuwat = new Person();
            anuwat.FirstName = "Anuwat";
            anuwat.LastName = "Khongchuai";
            anuwat.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            var numbers = new int[3];

            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);


            string[] names = new string[3] {"Anuwat", "Pansa", "Surachad"};


            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);


            String screenName = "un4";

            int num;
            Int32 Num;


            var firstName = "Anuwat";
            var lastName = "Khongchuai";

            var fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);

            var namesArr = new string[3] {"Anuwat", "Pansa", "Surachad"};

            var forMattedName = string.Join("|", namesArr);

            Console.WriteLine(forMattedName);

            // verbatim string

            var text = @"Hi john
Look into the following paths: 
C:\Users\anuwat\Documents\git-repos\ms-c-sharp-research";
            Console.WriteLine(text);


            var method = ShippingMethod.Express;

            Console.WriteLine((int)method);

            var methodId = 2;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method); // call default ToString()

            Console.WriteLine(method.ToString());

            var methodName = "Express";

            // parsing string to difference type

           var shippingMethod =  (ShippingMethod)System.Enum.Parse(typeof(ShippingMethod), methodName);
           Console.WriteLine(shippingMethod);

        }
    }
}