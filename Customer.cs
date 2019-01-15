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
        private BusinessType businessType;
        
        public Customer (string code, string name, string address, BusinessType businessType)
        {
            this.code = code;
            this.name = name;
            this.address = address;
            this.businessType = businessType;
        }

        public string DisplayCustomer (Customer customer)
        {
            return customer.code + ", "
                + customer.name +", "
                + customer.address +" ,"
                + customer.businessType;
        }

    }
}
