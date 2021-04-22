namespace Cotix.Domain.Entities
{
    public class Product : AuditableEntity,IDisableable
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Specification { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public string PicturePath { get; set; }
        public bool Disabled { get; set; }
    }
}