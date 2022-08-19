using CompanyWebApi.Domains.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyWebApi.Domains.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> ListAsync();
        Task AddAsync(Employee employee);
    }
}
