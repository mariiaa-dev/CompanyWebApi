using CompanyWebApi.Domeins.Models;
using CompanyWebApi.Domeins.Services.Communication;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyWebApi.Domeins.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> ListAsync();
        Task<SaveEmployeeResponse> SaveAsync(Employee employee);
    }
}
