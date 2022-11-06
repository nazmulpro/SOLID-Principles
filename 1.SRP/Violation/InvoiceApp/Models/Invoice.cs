using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Models
{
    public class Invoice
    {
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public int  Quantity { get; set; }
        public Invoice(string itemName, double itemPrice,int quantity)
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
            this.Quantity = quantity;
        }

        public double CalculateTotal()
        {
           return this.ItemPrice * this.Quantity;
        }

        public void SaveInvoice()
        {
            // save code
            Console.WriteLine("Saved");
        }

        public void PrintInvoice()
        {
            //print invoice code
            Console.WriteLine("Print");
        }

        
    }
}
