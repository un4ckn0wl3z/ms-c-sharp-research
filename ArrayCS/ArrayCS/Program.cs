using System;

namespace ArrayCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {3, 7, 9, 2, 14, 6};

            // Length
            Console.WriteLine("Length {0}", numbers.Length);

            // IndexOf
            Console.WriteLine(Array.IndexOf(numbers, 14));

            Console.WriteLine("================================== Clear");
            // Clear
            Array.Clear(numbers,0,2);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("================================== Copy");

            // Copy
            var another = new int[3];
            Array.Copy(numbers, another, 3);

            foreach (var num in another)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("================================== Sort");
            // Sort
            Array.Sort(numbers);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }


            Console.WriteLine("================================== Reverse");
            // Reverse
            Array.Reverse(another);
            foreach (var num in another)
            {
                Console.WriteLine(num);
            }

        }
    }
}
