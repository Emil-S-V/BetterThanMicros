namespace BetterThanMicrosPOS.Database.Tables
{
    // Represents the Products table in the database
    // PK = ProductID
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public bool InStock { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<MealItem> mealItems { get; set; }
    }
}
