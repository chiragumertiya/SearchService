using SearchService.Infrastructure.Data.DatabaseManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchService.Services.Interface
{
    public interface ISearchPersonService
    {
        Task<List<TblPerson>> SearchPersonAsync(string searchTerm);
    }
}
