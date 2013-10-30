using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LazyInitializationLazyLoadPattern
{
    public class OrderBad
    {
        private Customer _customer;

        public Customer Customer
        {
            //Colaesce statement
            get { return _customer ?? (_customer = new Customer()); }            
        }

        public string PrintLabel()
        {
            //Even withing the class please use the public accessor meaning the property.
            string result = _customer.CompanyName; //probably result in null reference exception
            return result + "\n" + Customer.Address; //OK to access Customer 
        }
    }
}
