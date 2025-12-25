namespace BetterThanMicrosPOS.Database.Tables
{
    // Junction table representing the many-to-many relationship between Meals and Products
    public class MealItem
    {
        public int MealID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }

        public Meal Meal { get; set; }
        public Product Product { get; set; }
    }
}
