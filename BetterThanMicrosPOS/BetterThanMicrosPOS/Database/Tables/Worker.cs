namespace BetterThanMicrosPOS.Database.Tables
{
    // Represents the Worker table in the database
    // PK = workerID
    // Workers are employees who will process orders
    // They will be able to log into the POS system using their Personal Code
    // The higher the roleID, the more permissions they will have
    public class Worker
    {
        public int workerID { get; set; }
        public string workerName { get; set; }
        public string PersonalCode { get; set; }
        public int roleID { get; set; }
        public bool isActive { get; set; }

        public Role Role { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
