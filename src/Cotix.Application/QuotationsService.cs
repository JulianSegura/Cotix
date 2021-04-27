﻿using Cotix.AppLayer.Interfaces;
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
    }
}