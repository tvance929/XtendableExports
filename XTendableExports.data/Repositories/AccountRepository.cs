using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using XTendableExports.Domain;
using XTendableExports.Domain.Contracts.Repositories;

namespace XTendableExports.data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public async Task AddAsync(Account account)
        {
            using (var context = new EFContext())
            {
                context.Accounts.Add(account);

                await context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Account>> GetAllAsync()
        {
            using (var context = new EFContext())
            {
                var accounts = context.Accounts;
                return await accounts.ToListAsync();
            }
        }

        public async Task<Account> GetAsync(Guid id)
        {
            using (var context = new EFContext())
            {
                var account = await context.Accounts.Where(a => a.Id == id).FirstOrDefaultAsync();
                return account;
            }
        }
    }
}