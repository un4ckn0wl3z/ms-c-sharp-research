using System;
using System.Collections.Generic;

namespace ListCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>(){1,2,3,4};
            numbers.Add(5);
            numbers.AddRange(new List<int>(){7,8,1});

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("IndexOf 1 is: "+numbers.IndexOf(1));
            Console.WriteLine("Last IndexOf 1 is: "+numbers.LastIndexOf(1));

            Console.WriteLine("Count: " + numbers.Count);
            numbers.Remove(1);

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }



        }
    }
}
