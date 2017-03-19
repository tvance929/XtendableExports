using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTendableExports.Domain.Contracts.Repositories
{
    public interface IExportRepository
    {
        Task<IEnumerable<Export>> GetAllAsync();
        Task<Export> GetAsync(Guid id);
    }
}
