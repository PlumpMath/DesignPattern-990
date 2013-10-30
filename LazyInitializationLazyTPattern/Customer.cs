using System;
using System.Diagnostics;

namespace LazyInitializationLazyTPattern
{
    public class Customer
    {

        public Customer()
        {
            Debug.Print("Initializing Customer");
        }

        public string CompanyName { get; set; }

        public string Address { get; set; }
    }
}
