namespace BetterThanMicrosPOS.Database.Tables
{
    public class OrderModifier
    {
        public int OrderItemID { get; set; }
        public int ModifierID { get; set; }

        public OrderItem OrderItem { get; set; }
        public Modifier Modifier { get; set; }
    }
}
