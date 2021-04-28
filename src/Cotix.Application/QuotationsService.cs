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
    public class QuotationsService
    {
        private readonly IUnitOfWork _UoW;
        private readonly IRepository<Quotation> _quotationsRepo;
        
        public QuotationsService(IUnitOfWork UoW)
        {
            _UoW = UoW;
            _quotationsRepo = _UoW.QuotationsRepo;
        }

        public ServiceResponse<Quotation> Add(Quotation quotation)
        {
            var response = new ServiceResponse<Quotation>();
            try
            {
                _quotationsRepo.Add(quotation);
                _UoW.Complete();
                response.IsSuccessful = true;
                response.ResultObject = quotation;
            }
            catch (Exception e)
            {

                response.SetException(e);
            }

            return response;
        }

        public ServiceResponse<Quotation> Update(Quotation quotation)
        {
            var response = new ServiceResponse<Quotation>();
            try
            {
                _quotationsRepo.Update(quotation);
                _UoW.Complete();
                response.IsSuccessful = true;
                response.ResultObject = quotation;
            }
            catch (Exception e)
            {

                response.SetException(e);
            }

            return response;
        }

        public ICollection<Quotation> GetAll()
        {
            return _quotationsRepo.GetAll();
        }

        public bool Delete(int id)
        {
            try
            {
                _quotationsRepo.Delete(id);
                _UoW.Complete();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Quotation GetById(int id)
        {
            return _quotationsRepo.GetById(id);
        }
    }
}
