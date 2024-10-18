
namespace Test.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public required string Firstname { get; set; }
        public required string Lastname { get; set; }
        public required string Email { get; set; }
        public bool IsActivated { get; set; } = true;
        public bool IsMegaAdmin { get; set; } = false;
        public Guid? SelectedTenantId { get; set; }
        public Tenant? SelectedTenant { get; set; }
        public Guid Version { get; set; }

    }
}
