namespace InvoiceApp.Models
{
    public class InvoiceDao
    {
        private Invoice _invoice;
        public InvoiceDao(Invoice invoice)
        {
            _invoice = invoice;
        }

        public void SaveInvoice()
        {
            Console.WriteLine("Saved");
            // save code
        }
    }
}
