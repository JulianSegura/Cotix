using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cotix.Domain.Entities
{
    public class Customer : DisableableBaseEntity
    {
        //ToDo Add data annotations
        public Customer()
        {
            Quotations = new HashSet<Quotation>();
        }

        public string Company { get; set; }
        
        [Required]
        public string Name { get; set; }

        public string Email { get; set; }
        
        [Required]
        public string PhoneNumber { get; set; }

        #region Navigation
        public virtual ICollection<Quotation> Quotations { get; private set; }
        #endregion

        public void ToUpper()
        {
            Name = Name.ToUpper();
            Company = Company.ToUpper();
            Email = Email.ToUpper();
        }
    }
}