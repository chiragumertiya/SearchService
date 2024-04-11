using SearchService.Domain.Interface;
using SearchService.Infrastructure.Data.DatabaseManager;
using SearchService.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SearchService.Services
{
    public class SearchPersonService : BaseService, ISearchPersonService
    {
        public SearchPersonService(IUnitOfWork unitOfWork): base(unitOfWork) 
        {
        }

        public async Task<List<TblPerson>> SearchPersonAsync(string searchTerm)
        {
            return await _unitOfWork.SearchServiceRepositoryDetails.SearchPersonAsync(searchTerm);
        }
    }
}
