namespace BetterThanMicrosPOS.Database.Tables
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public int OrderID { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public float Amount { get; set; }
        public string PaymentMethod { get; set; }

        public Order Order { get; set; }
    }
}
