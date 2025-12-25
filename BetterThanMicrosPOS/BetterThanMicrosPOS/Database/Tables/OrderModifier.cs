namespace BetterThanMicrosPOS.Database.Tables
{
    // Junction table representing the many-to-many relationship between OrderItems and Modifiers
    public class OrderModifier
    {
        public int OrderItemID { get; set; }
        public int ModifierID { get; set; }

        public OrderItem OrderItem { get; set; }
        public Modifier Modifier { get; set; }
    }
}
