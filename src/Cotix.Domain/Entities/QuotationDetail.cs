namespace Cotix.Domain.Entities
{
    public class QuotationDetail : BaseEntity
    {
        public int Quantity { get; set; }
        public decimal Total { get; set; }

        #region Navigation
        public virtual Product Product { get; set; }
        public virtual Quotation Quotation { get; set; }

        #endregion
    }
}