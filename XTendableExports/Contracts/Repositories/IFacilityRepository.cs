using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XTendableExports.domain.Contracts.Repositories
{
    public interface IFacilityRepository
    {
        Task<IEnumerable<Facility>> GetAllAsync();
        Task<Facility> GetAsync(Guid id);
    }
}
