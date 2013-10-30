using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LazyInitializationLazyTPattern
{
    public class OrderLazy
    {
        private readonly Lazy<Customer> _customInitializer;

        public OrderLazy()
        {
            //Lazy<T> defaults to thread safe - set ThreadSafe to false if not needed
            _customInitializer = new Lazy<Customer>(()=> new Customer
                                                             {
                                                                 Address = "Default Address",
                                                                 CompanyName = "Company Name"
                                                             });
        }

        public Customer Customer
        {
            get { return _customInitializer.Value; }
        }

        public string PrintLabel()
        {
            
            string result = Customer.CompanyName; //Ok to access Customer
            return result + "\n" + _customInitializer.Value.Address; //OK to access customInitializer
        }
    }
}
