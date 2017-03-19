using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using XTendableExports.Domain;
using XTendableExports.Domain.Contracts.Repositories;

namespace XTendableExports.data.Repositories
{
    public class ExportRepository : IExportRepository
    {
        EFContext context;

        public ExportRepository(EFContext context)
        {
            this.context = context;
        }

        public async Task<List<Export>> GetAllAsync()
        {
            var exports = this.context.Exports;
            return await exports.ToListAsync();
        }

        public async Task<Export> GetAsync(Guid id)
        {
            var export = await this.context.Exports.Where(a => a.Id == id).FirstOrDefaultAsync();
            return export;
        }

        public async Task AddAsync(Export export)
        {
            this.context.Exports.Add(export);
            await context.SaveChangesAsync();
        }
    }
}
