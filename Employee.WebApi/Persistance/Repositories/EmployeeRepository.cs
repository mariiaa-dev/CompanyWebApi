using CompanyWebApi.Domains.Models;
using CompanyWebApi.Domains.Repositories;
using CompanyWebApi.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyWebApi.Persistance.Repositories
{
    public class EmployeeRepository : BaseRopository, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext context) : base(context)
        {
        }

        public async Task AddAsync(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
        }

        public async Task<IEnumerable<Employee>> ListAsync()
        {
            return await _context.Employees.ToListAsync();
        }
    }
}
