using System;
using System.Runtime.InteropServices;

namespace ConstructorCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "Anuwat";

            var order = new Order();
            customer.Orders.Add(order);


            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);



        }
    }
}