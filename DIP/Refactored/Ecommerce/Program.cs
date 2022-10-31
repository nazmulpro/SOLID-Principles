using Ecommerce.Models;
using Ecommerce.Services;
using Ecommerce.Services.sms;

namespace Ecommerce
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer aCustomer = new Customer("nazmul", "nazmulprobd@gmail.com", "017155");
            ShoppingCart shoppingCart = new ShoppingCart(100, aCustomer);

            //GPSmsProvider gpSms = new GPSmsProvider();
            //SmsService smsService = new SmsService(gpSms);
            RobiSmsProvider robiSms = new RobiSmsProvider();
            SmsService smsService = new SmsService(robiSms);


            CheckoutService checkoutService = new CheckoutService(smsService);
            checkoutService.Checkout(shoppingCart);
            
        }
    }
}