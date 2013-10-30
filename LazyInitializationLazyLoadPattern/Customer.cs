using System;

namespace LazyInitializationLazyLoadPattern
{
    public class Customer
    {

        public Customer()
        {
            Console.WriteLine("Initializing Customer");
        }

        public string CompanyName { get; set; }

        public string Address { get; set; }
    }
}
