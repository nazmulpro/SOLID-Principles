using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class CheckoutService
    {
        private SmsService _SmsService;
        public CheckoutService()
        {
            this._SmsService = new SmsService();
        }

        public void Checkout(ShoppingCart shoppingCart)
        {
            Console.WriteLine("Checkingout... ");
            sendConfirmationSms(shoppingCart);
        }

        private void sendConfirmationSms(ShoppingCart shoppingCart)
        {
           string text = $"Hello,{shoppingCart.GetCustomer().GetFullName()} .Thanks for shopping ...";
           _SmsService.sendSms(text, shoppingCart.GetCustomer().GetPhoneNumber());
           
        }
    }
}
