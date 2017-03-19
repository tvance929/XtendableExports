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
        public async Task<List<Export>> GetAllAsync()
        {
            using (var context = new EFContext())
            {
                var exports = context.Exports;
                return await exports.ToListAsync();
            }
        }

        public async Task<Export> GetAsync(Guid id)
        {
            using (var context = new EFContext())
            {
                var export = await context.Exports.Where(a => a.Id == id).FirstOrDefaultAsync();
                return export;
            }
        }
    }
}
