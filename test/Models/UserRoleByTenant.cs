namespace Test.Models
{
    public class UserRoleByTenant
    {
        public Guid Id { get; set; }
        public Guid UserTenantId { get; set; }
        public UserTenant? UserTenant { get; set; }
        public Guid RoleId { get; set; }
        public Role? Role { get; set; }
        public Guid Version { get; set; }
    }
}
