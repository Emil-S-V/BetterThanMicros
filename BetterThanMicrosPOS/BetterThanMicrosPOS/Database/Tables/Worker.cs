namespace BetterThanMicrosPOS.Database.Tables
{
    public class Worker
    {
        public int workerID { get; set; }
        public string workerName { get; set; }
        // Login field
        public string PersonalCode { get; set; }
        public int roleID { get; set; }
        public bool isActive { get; set; }

        public Role Role { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
