using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XTendableExports.Domain.Contracts.Repositories
{
    public interface IFacilityRepository
    {
        Task<IEnumerable<Facility>> GetAllAsync();
        Task<Facility> GetAsync(Guid id);
    }
}
