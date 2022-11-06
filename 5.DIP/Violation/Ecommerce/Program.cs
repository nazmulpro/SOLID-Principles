using Ecommerce.Models;
using Ecommerce.Services;

namespace Ecommerce
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer aCustomer = new Customer("nazmul", "nazmulprobd@gmail.com", "017155");
            ShoppingCart shoppingCart = new ShoppingCart(100, aCustomer);

            CheckoutService checkoutService = new CheckoutService();
            checkoutService.Checkout(shoppingCart);
            
        }
    }
}