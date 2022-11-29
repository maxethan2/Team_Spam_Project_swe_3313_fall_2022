namespace CoffeePointOfSale.Services.Customer
{
    public class Order
    {
        public string CustomerId { get; set; }
        public string Date { get; set; }
        public decimal Tax { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
        public string PaymentMethod { get; set; }
        public List<OrderedItem> OrderedItems { get; set; } = new();
    }
}