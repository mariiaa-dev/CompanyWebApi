using CompanyWebApi.Persistance.Contexts;
using CompanyWebApi.Domains.Repositories;
using CompanyWebApi.Domains.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CompanyWebApi.Persistance.Repositories
{
    public class CompanyRepository : BaseRopository, ICompanyRepository
    {
        public CompanyRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Company>> ListAsync()
        {
            return await _context.Companies.ToListAsync();
        }
    }
}
