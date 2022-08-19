using CompanyWebApi.Domains.Models;
using CompanyWebApi.Domains.Services.Communication;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyWebApi.Domains.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> List();
        Task<SaveEmployeeResponse> SaveAsync(Employee employee);
    }
}
