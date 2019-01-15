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
        private Person contact;
        
        public Customer (string code, string name, string address, BusinessType businessType, Person contact)
        {
            this.code = code;
            this.name = name;
            this.address = address;
            this.businessType = businessType;
            this.contact = contact;
        }

        public string DisplayCustomer (Customer customer)
        {
            return customer.code + ", "
                + customer.name + ", "
                + customer.address +" ," 
                + customer.businessType + " ,"
                + customer.contact;
        }

    }
}
