using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Customer
    {
        private string _name;
        private string _emailAddress;
        private string _phoneNumber;

        public Customer(string name,string emailAddress,string phoneNumber)
        {
            this._name = name;
            this._emailAddress = emailAddress;
            this._phoneNumber = phoneNumber;
        }
        public string GetFullName()
        {
           return _name;
        }
        public string GetPhoneNumber()
        {
            return _phoneNumber;
        }
    }
}
