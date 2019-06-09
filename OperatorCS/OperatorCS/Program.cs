using System;


namespace OperatorCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = a++;


            int c = 1;
            int d = ++c;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine("-------------------------");
            var x = 1;
            var y = 2;
            var z = 3;
            Console.WriteLine(x + z);
            Console.WriteLine((float)x / (float)z);





            Console.WriteLine(x + y * z);
            Console.WriteLine((x + y) * z);
            Console.WriteLine(x > y);
            Console.WriteLine(x == y);
            Console.WriteLine(x != y);
            Console.WriteLine(!(x != y));

            Console.WriteLine( z > x &&  z > y);
            Console.WriteLine(z > x && z == y);
            Console.WriteLine(z > x || z == y);



        }
    }
}
