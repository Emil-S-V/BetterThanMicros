namespace BetterThanMicrosPOS.Database.Tables
{
    // Represents an item within an order
    // PK = OrderItemID
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public int? ProductID { get; set; }
        public int? MealID { get; set; }
        public int Quantity { get; set; }
        public float PriceAtPurchase { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
        public Meal Meal { get; set; }

        public ICollection<OrderModifier> OrderModifiers { get; set; } = new List<OrderModifier>();
    }
}
