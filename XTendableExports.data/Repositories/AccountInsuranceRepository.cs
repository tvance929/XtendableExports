using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using XTendableExports.Domain;
using XTendableExports.Domain.Contracts.Repositories;

namespace XTendableExports.data.Repositories
{
    public class AccountInsuranceRepository : IAccountInsuranceRepository
    {
        public async Task<IEnumerable<AccountInsurance>> GetAllAsync()
        {
            using (var context = new EFContext())
            {
                var accountInsurances = context.AccountInsurances;
                return await accountInsurances.ToListAsync();
            }
        }

        public async Task<AccountInsurance> GetAsync(Guid id)
        {
            using (var context = new EFContext())
            {
                var accountInsurance = await context.AccountInsurances.Where(a => a.Id == id).FirstOrDefaultAsync();
                return accountInsurance;
            }
        }
    }
}
