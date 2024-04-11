using SearchService.Domain.Interface;
using SearchService.Domain.Interface.RepositoryInterface;
using SearchService.Infrastructure.Data.DatabaseManager;
using SearchService.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchService.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly SearchServiceDbContext _searchServiceDBContext;
        public ISearchServiceRepository SearchServiceRepository;

        public UnitOfWork(SearchServiceDbContext searchServiceDbContext)
        {
            this._searchServiceDBContext = searchServiceDbContext;
        }

        public ISearchServiceRepository SearchServiceRepositoryDetails => SearchServiceRepository = SearchServiceRepository ?? new SearchServiceRepository(_searchServiceDBContext);


        public int Commit()
        {
            return this._searchServiceDBContext.SaveChanges();
        }

        public async Task<int> CommitAsync()
        {
            return await this._searchServiceDBContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            if (this._searchServiceDBContext != null)
            {
                this._searchServiceDBContext.Dispose();
            }
        }
    }
}
