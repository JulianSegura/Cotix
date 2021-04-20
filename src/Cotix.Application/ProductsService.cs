using System;
using System.Collections.Generic;
using System.Linq;
using Cotix.Application.Interfaces;
using Cotix.Domain.Entities;

namespace Cotix.Application
{
    public class ProductsService
    {
        private readonly IUnitOfWork _uow;
        private readonly IRepository<Product> _productsRepo;

        public ProductsService(IUnitOfWork UoW)
        {
            _uow = UoW;
            _productsRepo = _uow.ProductsRepo;
        }

        public ICollection<Product> GetAll()
        {
            return _productsRepo.GetAll().ToList();
        }

        public Product GetById(int id)
        {
            return _productsRepo.GetById(id);
        }

        public ICollection<Product> Search(string productCode=null,string productDesc=null)
        {
            var lst = new List<Product>();

            if (productCode == null && productDesc == null) return lst;

            if (productCode != null)
            {
                lst = _productsRepo.Get(p => p.Code == productCode.ToUpper()).ToList();
                return lst;
            }

            if (productDesc != null)
            {
                lst = (from p in _productsRepo.GetAll()
                       where p.Description.Contains(productDesc)
                       select p).ToList();
                return lst;
            }

            return lst;
        }

        public void Add(Product product)
        {
            try
            {
                _productsRepo.Add(product);
                _uow.Complete();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Update(Product product)
        {
            try
            {
                _productsRepo.Update(product);
                _uow.Complete();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                _productsRepo.Delete(id);
                _uow.Complete();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}