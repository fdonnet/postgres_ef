namespace Test.Models
{
    public class Role
    {
        public Guid Id { get; set; }
        public required string Code { get; set; }
        public required string Label { get; set; }
        public string? Description { get; set; }
        public Guid? TenantId { get; set; }
        public Tenant? Tenant { get; set; }
        public Guid Version { get; set; }

    }
}
