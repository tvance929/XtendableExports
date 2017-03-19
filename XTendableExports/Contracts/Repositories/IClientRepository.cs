using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTendableExports.Domain.Contracts.Repositories
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAllAsync();
        Task<Client> GetAsync(Guid id);
    }
}
