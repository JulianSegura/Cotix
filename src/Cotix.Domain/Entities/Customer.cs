﻿using System.Collections.Generic;

namespace Cotix.Domain.Entities
{
    public class Customer : DisableableBaseEntity
    {
        //ToDo Add data annotations
        public Customer()
        {
            Quotations = new HashSet<Quotation>();
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CellPhone { get; set; }

        #region Navigation
        public virtual ICollection<Quotation> Quotations { get; private set; }
        #endregion
    }
}