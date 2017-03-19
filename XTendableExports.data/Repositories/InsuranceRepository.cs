using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using XTendableExports.Domain;
using XTendableExports.Domain.Contracts.Repositories;

namespace XTendableExports.data.Repositories
{
    public class InsuranceRepository : IInsuranceRepository
    {
        public async Task<IEnumerable<Insurance>> GetAllAsync()
        {
            using (var context = new EFContext())
            {
                var insurances = context.Insurances;
                return await insurances.ToListAsync();
            }
        }

        public async Task<Insurance> GetAsync(Guid id)
        {
            using (var context = new EFContext())
            {
                var insurance = await context.Insurances.Where(a => a.Id == id).FirstOrDefaultAsync();
                return insurance;
            }
        }
    }
}
