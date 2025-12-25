namespace BetterThanMicrosPOS.Database.Tables
{
    // Modifier which can be applied to OrderItems
    public class Modifier
    {
        public int ModifierID { get; set; }
        public string ModifierName { get; set; }
        public float AdditionalCost { get; set; }

        public ICollection<OrderModifier> OrderModifiers { get; set; } = new List<OrderModifier>();
    }
}
