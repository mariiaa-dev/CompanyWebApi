using CompanyWebApi.Domains.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CompanyWebApi.Domains.Repositories
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> ListAsync(CancellationToken cancellationToken);
        Task AddAsync(Employee employee);
    }
}
