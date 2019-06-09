using System;

namespace RandomCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            const int passwordLength = 16;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(random.Next(1,10));
            //}

            //Console.WriteLine((int)'a');
            var buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char) ('a' + random.Next(0, 26));
            }

            var password = new string(buffer);

            Console.WriteLine(password);
            //Console.WriteLine('a' + 1);
        }
    }
}