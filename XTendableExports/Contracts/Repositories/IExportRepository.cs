using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XTendableExports.Domain.Contracts.Repositories
{
    public interface IExportRepository
    {
        Task<List<Export>> GetAllAsync();
        Task<Export> GetAsync(Guid id);
        Task AddAsync(Export export);
    }
}
