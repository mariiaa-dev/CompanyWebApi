using CompanyWebApi.Domeins.Models;
using CompanyWebApi.Domeins.Repositories;
using CompanyWebApi.Persistance.Contexts;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

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
