using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTendableExports.Domain.Contracts.Services
{
    public interface IExportService
    {
        Task<IEnumerable<Export>> GetAllAsync();
    }
}
