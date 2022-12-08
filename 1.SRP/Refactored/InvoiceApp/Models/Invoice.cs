namespace InvoiceApp.Models
{
    public class Invoice
    {
        private readonly string _itemName;
        private readonly double _itemPrice;
        private readonly int _quantity;
        
        public Invoice(string itemName, double itemPrice,int quantity)
        {
            _itemName = itemName;
            _itemPrice = itemPrice;
            _quantity = quantity;
        }

        public double CalculateTotal()
        {
           return this._itemPrice * this._quantity;
        }
       
    }
}
