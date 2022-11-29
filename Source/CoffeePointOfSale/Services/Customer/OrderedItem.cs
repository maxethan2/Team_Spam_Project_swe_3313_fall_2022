namespace CoffeePointOfSale.Services.Customer
{
    public class OrderedItem
    {
        public string DrinkName { get; set; }
        public int Quantity { get; set; }
        public List<string> Customizations { get; set; } = new List<string>();
    }
}