using CompanyWebApi.Domains.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CompanyWebApi.Domains.Repositories
{
    public interface ICompanyRepository
    {
        Task<List<Company>> ListAsync(CancellationToken cancellationToken);
    }
}
