namespace BetterThanMicrosPOS.Database.Tables
{
    public class Meal
    {
        public int MealID { get; set; }
        public string MealName { get; set; }
        public decimal MealPrice { get; set; }
        public bool IsAvailable { get; set; }

        public ICollection<MealItem> MealItems { get; set; } = new List<MealItem>();
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
