using System;


namespace TypeConversionCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte b = 1;
            //int i = b;
            //int b = 1;
            //byte i = (byte)b;

            //float f = 1.0f;
            //int i = (int)f;

            //string s = "1";
            //int i = (int)s; // error becuz it's not compat

            //int c = Convert.ToInt32(s);

            //int j = int.Parse(s);




            byte b = 1;
            int i = b;

            Console.WriteLine(i);


            int j = 1;
            byte c = (byte)j; // need to cast
            Console.WriteLine(c);

            // exceed case

            int a = 1000;
            byte x = (byte)a; // data lose
            Console.WriteLine(x);

            var number = "1234";
            //int n = (int)number; // impossible
            int n = Convert.ToInt32(number);
            Console.WriteLine(n);


            //================== byte
            try
            {
                var xecedd = "12345";
                //int n = (int)number; // impossible
                byte bt = Convert.ToByte(xecedd);
                Console.WriteLine(bt);
            }
            catch (Exception)
            {

                Console.WriteLine("Cannot converting...");
            }
     
            


        }
    }
}
