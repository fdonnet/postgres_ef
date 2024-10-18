namespace Test.Models
{
    public class UserTenant
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public Guid TenantId { get; set; }
        public Tenant? Tenant { get; set; }
        public Guid Version { get; set; }

    }
}
