using CompanyWebApi.Domains.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CompanyWebApi.Domains.Services
{
    public interface ICompanyService
    {
        Task<List<Company>> ListAsync(CancellationToken cancellationToken);
    }
}