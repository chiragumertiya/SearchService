using SearchService.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchService.Services
{
    public class BaseService
    {
        protected readonly IUnitOfWork _unitOfWork;
        public BaseService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
    }
}
