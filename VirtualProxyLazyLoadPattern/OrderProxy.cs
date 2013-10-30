using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualProxyLazyLoadPattern
{
    class OrderProxy: Order
    {
        public override Customer Customer
        {
            get { return base.Customer ?? (base.Customer = new Customer
                                                               {
                                                                   Address = "Default Address",
                                                                   CompanyName = "Company Name"
                                                               }); }
            set
            {
                base.Customer = value;
            }            
        }

        public override bool Equals(object obj)
        {
            var other = obj as Order;
            return other != null && other.Id == this.Id;
            
        }
    }
}
