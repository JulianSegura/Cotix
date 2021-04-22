namespace Cotix.Domain.Entities
{
    public class QuotationDetail : BaseEntity
    {
        public int Quantity { get; set; }
        public decimal Amount { get; set; }

        #region Navigation
        public virtual Product Product { get; set; }
        public virtual Quotation Quotation { get; set; }

        #endregion
    }
}