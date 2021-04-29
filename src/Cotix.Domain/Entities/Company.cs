namespace Cotix.Domain.Entities
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string LogoUrl { get; set; }

        private static Company instance=null;

        public static Company Get()
        {
            return instance= instance ?? new Company();
        }
        private Company()
        {
            instance = new Company();
        }
    }
}
