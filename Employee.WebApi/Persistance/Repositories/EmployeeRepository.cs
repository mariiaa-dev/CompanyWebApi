using CompanyWebApi.Domeins.Models;
using CompanyWebApi.Domeins.Repositories;
using CompanyWebApi.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

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

/*        public Task<IQueryable<IGrouping<decimal,Employee>>> GetSalarySumByCompany(int companyId)
        {
            var sum = from employee in _context.Employees
                      join company in _context.Companies on employee.CompanyId equals company.Id
                      where employee.CompanyId == companyId
                      group employee by employee.Salary into empSalary
                      select empSalary;

            return Task.FromResult(sum);
        }*/
    }
}
