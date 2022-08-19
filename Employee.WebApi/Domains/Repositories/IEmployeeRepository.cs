using CompanyWebApi.Domains.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyWebApi.Domains.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> List();
        Task AddAsync(Employee employee);
    }
}
