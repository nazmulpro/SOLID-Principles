namespace InvoiceApp.Models
{
    public class InvoicePrinter
    {
        private Invoice _invoice;
        public InvoicePrinter(Invoice invoice)
        {
            this._invoice = invoice;
        }

        public void Print()
        {
            // print code
        }
    }
}
