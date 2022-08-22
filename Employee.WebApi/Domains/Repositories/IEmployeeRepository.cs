using CompanyWebApi.Domains.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CompanyWebApi.Domains.Repositories
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> ListAsync(CancellationToken cancellationToken);
        void AddAsync(Employee employee);
    }
}
