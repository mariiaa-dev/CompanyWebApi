﻿using System.Threading;
using System.Threading.Tasks;

namespace CompanyWebApi.Domains.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync(CancellationToken cancellationToken);
    }
}
