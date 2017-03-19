using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using XTendableExports.Domain;
using XTendableExports.Domain.Contracts.Repositories;

namespace XTendableExports.data.Repositories
{
    public class FacilityRepository : IFacilityRepository
    {
        public async Task<IEnumerable<Facility>> GetAllAsync()
        {
            using (var context = new EFContext())
            {
                var facilities = context.Facilities;
                return await facilities.ToListAsync();
            }
        }

        public async Task<Facility> GetAsync(Guid id)
        {
            using (var context = new EFContext())
            {
                var facility = await context.Facilities.Where(a => a.Id == id).FirstOrDefaultAsync();
                return facility;
            }
        }
    }
}
