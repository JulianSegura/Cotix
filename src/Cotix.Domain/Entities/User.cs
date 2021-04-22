namespace Cotix.Domain.Entities
{
    public class User : DisableableBaseEntity
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }
}