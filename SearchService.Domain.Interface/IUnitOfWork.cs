using SearchService.Domain.Interface.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchService.Domain.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        ISearchServiceRepository SearchServiceRepositoryDetails { get; }
        int Commit();
        Task<int> CommitAsync();
    }
}
