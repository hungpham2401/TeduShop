using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model;

namespace TeduShop.Service
{
    public interface IErrorService
    {
        Error Create(Error error);
        void Save();
    }
    class ErrorService : IErrorService
    {
        IErrorRepository _errorMessage;
        IUnitOfWork _unitOfWork;
        public ErrorService(IErrorRepository errorMessage, IUnitOfWork unitOfWork)
        {
            this._errorMessage = errorMessage;
            this._unitOfWork = unitOfWork;
        }

        public Error Create(Error Error)
        {
            return _errorMessage.Add(Error);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
