using Microsoft.EntityFrameworkCore;
using SearchService.Domain.Entities.Entities;
using SearchService.Domain.Interface;
using SearchService.Domain.Interface.RepositoryInterface;
using SearchService.Infrastructure.Data.DatabaseManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchService.Infrastructure.Data.Repositories
{
    public class SearchServiceRepository : Repository<Person>, ISearchServiceRepository
    {
        private readonly SearchServiceDbContext _searchServiceDbContext;
        public SearchServiceRepository(SearchServiceDbContext searchServiceDbContext) : base(searchServiceDbContext)
        {
            this._searchServiceDbContext = searchServiceDbContext;
        }

        public async Task<List<TblPerson>> SearchPersonAsync(string searchTerm)
        {

            //if (string.IsNullOrEmpty(searchTerm))
            //    return BadRequest("Search term cannot be empty");

            var result = await _searchServiceDbContext.TblPeople
                .Where(p => EF.Functions.Like(p.FirstName, $"%{searchTerm}%") ||
                            EF.Functions.Like(p.LastName, $"%{searchTerm}%"))
                .ToListAsync();


            return await Task.FromResult(result);

        }
    }
}
