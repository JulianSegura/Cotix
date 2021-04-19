using Cotix.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotix.Application.Interfaces
{
    interface IUnitOfWork : IDisposable
    {
        IRepository<User> UsersRepo { get; }
        IRepository<Product> ProductsRepo { get; }
        IRepository<Quotation> QuotationsRepo { get; }
        IRepository<Customer> CustomersRepo { get; }
        void Complete();
    }
}
