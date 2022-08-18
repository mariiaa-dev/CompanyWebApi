using CompanyWebApi.Domains.Models;
using CompanyWebApi.Domains.Services.Communication;

namespace CompanyWebApi.Domains.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> ListAsync();
        Task<SaveEmployeeResponse> SaveAsync(Employee employee);
    }
}
