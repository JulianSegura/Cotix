using Cotix.Domain.Entities;

namespace Cotix.AppLayer
{
    public static class LoggedUser
    {
        public static int Id { get; private set; }
        public static string Name { get; private set; }
        public static UserRole Role { get; private set; }

        public static void SetUser(User user)
        {
            Id = user.Id;
            Name = user.Name;
            Role = user.Role;
        }
    }
}