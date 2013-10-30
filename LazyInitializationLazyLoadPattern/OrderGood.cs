using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LazyInitializationLazyLoadPattern
{
    public class OrderGood
    {
        private Customer _customer;

        public Customer Customer
        {
            //Colaesce statement
            get { return _customer ?? (_customer = new Customer
                                                       {
                                                           Address = "Default Address",
                                                           CompanyName = "Company Name"
                                                       }); }
        }

        public string PrintLabel()
        {
            //Even withing the class please use the public accessor meaning the property.
            string result = Customer.CompanyName; //not result in null reference exception
            return result + "\n" + Customer.Address; //OK to access Customer 
        }
    }
}
