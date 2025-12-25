namespace BetterThanMicrosPOS.Database.Tables
{
    public class Modifier
    {
        public int ModifierID { get; set; }
        public string ModifierName { get; set; }
        public float AdditionalCost { get; set; }

        public ICollection<OrderModifier> OrderModifiers { get; set; } = new List<OrderModifier>();
    }
}
