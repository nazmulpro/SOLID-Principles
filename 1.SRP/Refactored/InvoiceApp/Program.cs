using InvoiceApp.Models;

namespace InvoiceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice("product 1", 100, 5);
            Console.WriteLine(invoice.CalculateTotal());
            
            InvoiceDao invoiceDao = new InvoiceDao(invoice);
            invoiceDao.SaveInvoice();
        }
    }
}