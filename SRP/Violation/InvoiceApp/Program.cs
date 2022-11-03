using InvoiceApp.Models;

namespace InvoiceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice("product 1", 100, 200);

            Console.WriteLine(invoice.CalculateTotal());
            invoice.SaveInvoice();
            invoice.PrintInvoice();
            
        }
    }
}