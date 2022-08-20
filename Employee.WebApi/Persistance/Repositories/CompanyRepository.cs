using CompanyWebApi.Persistance.Contexts;
using CompanyWebApi.Domains.Repositories;
using CompanyWebApi.Domains.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace CompanyWebApi.Persistance.Repositories
{
    public class CompanyRepository : BaseRepository, ICompanyRepository
    {

        public CompanyRepository(AppDbContext context) : base(context)
        {
        }

        public Task<List<Company>> ListAsync(CancellationToken cancellationToken)
        {
            return _context.Companies.ToListAsync(cancellationToken);
        }
    }
}
