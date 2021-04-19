using System;

namespace Cotix.Domain.Entities
{
    public interface IAuditable
    {
        DateTime CreatedAt { get; set; }
        int CreatedBy { get; set; }
        DateTime LastUpdatedAt { get; set; }
        int LastUpdatedBy { get; set; }
    }

    public interface IDisableable
    {
        bool Disabled { get; set; }
    }
}