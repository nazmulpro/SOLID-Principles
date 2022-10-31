using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class ShoppingCart
    {
        private double _totalAmount;
        private Customer _customer;

        public ShoppingCart(double total,Customer customer)
        {
            this._totalAmount = total;
            this._customer = customer;
        }

        public double TotalAmount() { return _totalAmount; }
        public Customer GetCustomer() { return _customer; }


    }
}
