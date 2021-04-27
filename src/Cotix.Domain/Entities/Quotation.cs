using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cotix.Domain.Entities
{
    public class Quotation : AuditableEntity
    {
        public Quotation()
        {
            Details = new HashSet<QuotationDetail>();
        }

        public DateTime ValidUntil { get; set; }

        [Required]
        public decimal SubTotal { get; set; }

        public decimal TransportationFee { get; set; }

        [Required]
        public decimal Total { get; set; }

        #region Navigation
        public virtual ICollection<QuotationDetail> Details { get; private set; }
        
        [Required]
        public virtual Customer Customer { get; set; }
        #endregion
    }
}