﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using XTendableExports.domain;
using XTendableExports.domain.Contracts.Repositories;

namespace XTendableExports.data.Repositories
{
    public class ExportRepository : IExportRepository
    {
        public async Task<IEnumerable<Export>> GetAllAsync()
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