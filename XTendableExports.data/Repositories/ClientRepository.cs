using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using XTendableExports.Domain;
using XTendableExports.Domain.Contracts.Repositories;

namespace XTendableExports.data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public async Task<IEnumerable<Client>> GetAllAsync()
        {
            using (var context = new EFContext())
            {
                var clients = context.Clients;
                return await clients.ToListAsync();
            }
        }

        public async Task<Client> GetAsync(Guid id)
        {
            using (var context = new EFContext())
            {
                var client = await context.Clients.Where(a => a.Id == id).FirstOrDefaultAsync();
                return client;
            }
        }
    }
}