using SearchService.Domain.Entities.Entities;
using SearchService.Infrastructure.Data.DatabaseManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchService.Domain.Interface.RepositoryInterface
{
    public interface ISearchServiceRepository
    {
        Task<List<TblPerson>> SearchPersonAsync(string searchTerm);
    }
}
