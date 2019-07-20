using System.Collections.Generic;

namespace ConstructorCS
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id) : this()
        {
            this.Id = id;
        }

        public Customer(string name) : this()
        {
            this.Name = name;
        }

        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }
    }
}