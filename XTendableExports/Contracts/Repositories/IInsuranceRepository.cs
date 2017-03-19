using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTendableExports.Domain.Contracts.Repositories
{
    public interface IInsuranceRepository
    {
        Task<IEnumerable<Insurance>> GetAllAsync();
        Task<Insurance> GetAsync(Guid id);
    }
}
