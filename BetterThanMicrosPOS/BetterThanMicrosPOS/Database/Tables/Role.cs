namespace BetterThanMicrosPOS.Database.Tables
{
    // Represents the Role table in the database
    // PK = RoleID
    // Workers will be assigned role
    public class Role
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        public ICollection<Worker> Workers { get; set; } = new List<Worker>();
    }
}
