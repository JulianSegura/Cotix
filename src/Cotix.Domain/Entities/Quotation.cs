using System;
using System.Collections.Generic;

namespace Cotix.Domain.Entities
{
    public class Quotation : AuditableEntity
    {
        public Quotation()
        {
            Details = new HashSet<QuotationDetail>();
        }
        public DateTime ValidUntil { get; set; }
        public decimal TransportationFee { get; set; }
        public decimal Total { get; set; }

        #region Navigation
        public virtual ICollection<QuotationDetail> Details { get; private set; }
        public virtual Customer Customer { get; set; }
        #endregion
    }
}