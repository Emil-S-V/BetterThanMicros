namespace BetterThanMicrosPOS.Database.Tables
{
    public class MealItem
    {
        public int MealID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }

        public Meal Meal { get; set; }
        public Product Product { get; set; }
    }
}
