using System;

namespace LoopCS
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (int i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            var name = "Anuwat Khongchuai";

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            foreach (var c in name)
            {
                Console.WriteLine(c);
            }

            var numbers = new int[] { 1,2,3,4};

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }


            Console.WriteLine("======================================");

            int counter = 1;

            while (counter <= 10)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine(counter);
                }
                counter++;
            }



        }
    }
}
