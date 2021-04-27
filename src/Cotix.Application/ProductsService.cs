using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Cotix.AppLayer.Interfaces;
using Cotix.Domain.Common;
using Cotix.Domain.Entities;

namespace Cotix.AppLayer
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
            }

            if (productDesc != null)
            {
                lst = (from p in _productsRepo.GetAll()
                       where p.Description.Contains(productDesc)
                       select p).ToList();
            }

            return lst;
        }

        public ServiceResponse<Product> Add(Product product)
        {
            var response = new ServiceResponse<Product>();
            try
            {
                _productsRepo.Add(product);
                _uow.Complete();
                response.IsSuccessful = true;
                response.ResultObject = product;
            }
            catch (Exception e)
            {
                response.SetException(e);
            }

            return response;
        }

        public ServiceResponse<Product> Update(Product product)
        {
            var response = new ServiceResponse<Product>();
            try
            {
                _productsRepo.Update(product);
                _uow.Complete();
                response.IsSuccessful = true;
                response.ResultObject = product;
            }
            catch (Exception e)
            {
                response.SetException(e);
            }

            return response;
        }

        public ServiceResponse<Product> Delete(int id)
        {
            var response = new ServiceResponse<Product>();
            try
            {
                _productsRepo.Delete(id);
                _uow.Complete();
                response.IsSuccessful = true;
            }
            catch (SqlException e)
            {
                response.SetException(e);
            }
            return response;
        }
    }
}