using Cotix.AppLayer.Interfaces;
using Cotix.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Cotix.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        private IRepository<User> _usersRepo;
        private IRepository<Product> _productsRepo;
        private IRepository<Quotation> _quotationsRepo;
        private IRepository<Customer> _customersRepo;


        public UnitOfWork()
        {
            if (_context == null) _context = new SqlLiteDataContext(); ;
        }
        public IRepository<User> UsersRepo
        {
            get
            {
                if (_usersRepo == null) _usersRepo = new Repository<User>(_context);
                return _usersRepo;
            }
        }

        public IRepository<Product> ProductsRepo
        {
            get
            {
                if (_productsRepo == null) _productsRepo = new Repository<Product>(_context);
                return _productsRepo;
            }
        }

        public IRepository<Quotation> QuotationsRepo
        {
            get
            {
                if (_quotationsRepo == null) _quotationsRepo = new Repository<Quotation>(_context);
                return _quotationsRepo;
            }
        }

        public IRepository<Customer> CustomersRepo
        {
            get
            {
                if (_customersRepo == null) _customersRepo = new Repository<Customer>(_context);
                return _customersRepo;
            }
        }

        public void Complete()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
