using CompanyWebApi.Domains.Models;
using CompanyWebApi.Domains.Services.Communication;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CompanyWebApi.Domains.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> ListAsync(CancellationToken cancellationToken);
        Task<SaveEmployeeResponse> SaveAsync(Employee employee);
    }
}
