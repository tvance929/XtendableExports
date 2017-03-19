using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XTendableExports.Domain.Contracts.Repositories
{
    public interface IAccountInsuranceRepository
    {
        Task<IEnumerable<AccountInsurance>> GetAllAsync();
        Task<AccountInsurance> GetAsync(Guid id);
    }
}
