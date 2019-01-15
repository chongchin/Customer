using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Customer
    {
        private string code;
        private string name;
        private string address;
        
        public Customer (string code, string name, string address)
        {
            this.code = code;
            this.name = name;
            this.address = address;
        }

        public string DisplayCustomer (Customer customer)
        {
            return customer.code + ", "
                + customer.name +", "
                + customer.address;
          
        }

    }
}
