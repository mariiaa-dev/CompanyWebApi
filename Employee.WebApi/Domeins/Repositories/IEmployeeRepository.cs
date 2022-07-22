using CompanyWebApi.Domeins.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyWebApi.Domeins.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> ListAsync();
        Task AddAsync(Employee employee);
        //Task<IQueryable<IGrouping<decimal, Employee>>> GetSalarySumByCompany(int companyId);
    }
}
