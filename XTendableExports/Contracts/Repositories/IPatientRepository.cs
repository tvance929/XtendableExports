using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XTendableExports.Domain.Contracts.Repositories
{
    public interface IPatientRepository
    {
        Task<IEnumerable<Patient>> GetAllAsync();
        Task<Patient> GetAsync(Guid id);
        Task AddAsync(Patient patient);
    }
}
