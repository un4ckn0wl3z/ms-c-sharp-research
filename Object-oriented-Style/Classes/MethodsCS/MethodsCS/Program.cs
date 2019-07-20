using System;

namespace MethodsCS
{
    class Program
    {
        static void Main(string[] args)
        {
            // var number = int.Parse("abc");
            int number;
            var result = int.TryParse("abc", out number);
            if (result) Console.WriteLine(number);
            else Console.WriteLine("Conversion failed.");
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5, 6, 7, 9));
        }

        static void UserPoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }
    }
}