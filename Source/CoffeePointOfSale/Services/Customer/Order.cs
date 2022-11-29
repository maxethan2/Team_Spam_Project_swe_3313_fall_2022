namespace CoffeePointOfSale.Services.Customer
{
    public class Order
    {
        public string CustomerId { get; set; }
        public string Date { get; set; }
        public double Tax { get; set; }
        public double Subtotal { get; set; }
        public double Total { get; set; }
        public string PaymentMethod { get; set; }
        public List<OrderedItem> OrderedItems { get; set; } = new();
    }
}