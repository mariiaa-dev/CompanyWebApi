using CompanyWebApi.Domains.Models;
using CompanyWebApi.Domains.Repositories;
using CompanyWebApi.Persistance.Contexts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyWebApi.Persistance.Repositories
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext context) : base(context)
        {
        }

        public Task AddAsync(Employee employee)
        {
            return _context.Employees.AddAsync(employee).AsTask();
        }

        public IEnumerable<Employee> ListAsync()
        {
            return _context.Employees.ToList();
        }
    }
}
