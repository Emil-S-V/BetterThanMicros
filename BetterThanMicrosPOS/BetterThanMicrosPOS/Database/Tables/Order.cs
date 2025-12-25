namespace BetterThanMicrosPOS.Database.Tables
{
    // Represents the Order table in the database
    // PK = orderID
    public class Order
    {
        public int orderID { get; set; }
        public DateTime orderDate { get; set; } = DateTime.Now;
        public string Status { get; set; }
        public float TotalAmount { get; set; }
        public OrderType orderType { get; set; }
        public int workerID { get; set; }

        public Worker Worker { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
