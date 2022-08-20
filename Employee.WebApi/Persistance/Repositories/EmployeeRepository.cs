using CompanyWebApi.Domains.Models;
using CompanyWebApi.Domains.Repositories;
using CompanyWebApi.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CompanyWebApi.Persistance.Repositories
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext context) : base(context)
        {
        }

        public Task AddAsync(Employee employee, CancellationToken cancellationToken)
        {
            return _context.Employees.Add(employee).ReloadAsync(cancellationToken);
        }

        public Task<List<Employee>> ListAsync(CancellationToken cancellationToken)
        {
            return _context.Employees.ToListAsync(cancellationToken);
        }
    }
}
