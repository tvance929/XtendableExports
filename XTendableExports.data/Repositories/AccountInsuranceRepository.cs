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
        EFContext context;

        public AccountInsuranceRepository(EFContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<AccountInsurance>> GetAllAsync()
        {
            var accountInsurances = this.context.AccountInsurances;
            return await accountInsurances.ToListAsync();
        }

        public async Task<AccountInsurance> GetAsync(Guid id)
        {
            var accountInsurance = await this.context.AccountInsurances.Where(a => a.Id == id).FirstOrDefaultAsync();
            return accountInsurance;
        }
    }
}
