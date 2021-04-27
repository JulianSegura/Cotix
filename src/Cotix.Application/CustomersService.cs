using Cotix.AppLayer.Interfaces;
using Cotix.Domain.Common;
using Cotix.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotix.AppLayer
{
    public class CustomersService
    {
        private readonly IUnitOfWork _UoW;
        private readonly IRepository<Customer> _customersRepo;

        public CustomersService(IUnitOfWork UoW)
        {
            _UoW = UoW;
            _customersRepo = _UoW.CustomersRepo;
        }

        public ServiceResponse<Customer> Add(Customer customer)
        {
            var response = new ServiceResponse<Customer>();
            try
            {
                customer.ToUpper();
                _customersRepo.Add(customer) ;
                _UoW.Complete();
                response.IsSuccessful = true;
                response.ResultObject = customer;
            }
            catch (Exception e)
            {
                response.SetException(e);
            }

            return response;
        }

        public ICollection<Customer> GetAll()
        {
            return _customersRepo.GetAll().ToList();
        }

        public ICollection<Customer> GetMatchingCustomers(string searchParam)
        {
            return _customersRepo.Get(c => c.Name.ToUpper().Contains(searchParam.ToUpper()));
        }
    }
}
