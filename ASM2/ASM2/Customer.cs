using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    internal class Customer
    {
        private string customerId;
        private string customerName;
        private string customerContact;

        public string CustomerId { get { return customerId; } set { customerId = value; } }
        public string CustomerName { get { return customerName; } set { customerName = value; } }
        public string CustomerContact { get { return customerContact; } set { customerContact = value; } }


        public Customer()
        {
            this.CustomerContact = null;
            this.CustomerId = null;
            this.CustomerName = null;
        }

        public Customer(string customerId, string customerName, string customerContact)
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.customerContact = customerContact;
        }
    }
}
