using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualProxyLazyLoadPattern
{
    public class Customer
    {

        public Customer()
        {
            Console.WriteLine("Initializing Customer"); //not thread safe 
        }

        public string CompanyName { get; set; }

        public string Address { get; set; }
    }
}
