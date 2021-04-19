using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotix.Domain.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
    }

    public class DisableableBaseEntity : BaseEntity, IDisableable
    {
        public bool Disabled { get; set; }
    }

    public class AuditableEntity : BaseEntity,IAuditable
    {
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public int LastUpdatedBy { get; set; }
    }
}
