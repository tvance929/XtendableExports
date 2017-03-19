using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XTendableExports.Domain;
using XTendableExports.Domain.Contracts.Repositories;
using XTendableExports.Domain.Contracts.Services;

namespace XtendableExports.services
{
    public class ExportService : IExportService
    {
        IExportRepository exportRepository;

        public ExportService (IExportRepository exportRepository)
        {
            this.exportRepository = exportRepository;
        }

        public async Task<IEnumerable<Export>> GetAllAsync()
        {
            return await this.exportRepository.GetAllAsync();
        }

        public async Task AddAsync(Export export)
        {
            //TODO:  Implement this for adding new custom exports
            throw new NotImplementedException();
        }
    }
}

