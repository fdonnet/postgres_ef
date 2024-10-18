namespace Test.Models
{
    public class Tenant
    {
        public Guid Id { get; set; }
        public required string Code { get; set; }
        public required string Label { get; set; }
        public required string Description { get; set; }
        public bool IsActivated { get; set; } = true;
        public Guid Version { get; set; }

    }
}
