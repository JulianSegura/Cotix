using Cotix.Domain.Entities;
using System;

namespace Cotix.Domain.Common
{
    public class ServiceResponse<T> where T : BaseEntity
    {
        public bool IsSuccessful { get; set; }
        public T ResultObject { get; set; }
        public Exception Exception { get; private set; }
        public string ErrorMessage { get; private set;}

        public void SetErrorMessage(string message)
        {
                ErrorMessage = message;
        }

        public void SetException(Exception e)
        {
            Exception = e;
            ErrorMessage = e.InnerException.Message;
        }
    }
}