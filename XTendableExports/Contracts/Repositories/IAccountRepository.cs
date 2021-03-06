﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XTendableExports.Domain.Contracts.Repositories
{
    public interface IAccountRepository
    {
        Task<IEnumerable<Account>> GetAllAsync();
        Task<Account> GetAsync(Guid id);
        Task AddAsync(Account account);
    }
}
