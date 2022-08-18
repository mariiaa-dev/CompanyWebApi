using CompanyWebApi.Domains.Models;

namespace CompanyWebApi.Domains.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> ListAsync();
        Task AddAsync(Employee employee);
    }
}
