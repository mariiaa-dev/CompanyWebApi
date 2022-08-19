using CompanyWebApi.Persistance.Contexts;
using CompanyWebApi.Domains.Repositories;
using CompanyWebApi.Domains.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CompanyWebApi.Persistance.Repositories
{
    public class CompanyRepository : BaseRepository, ICompanyRepository
    {
        public CompanyRepository(AppDbContext context) : base(context)
        {
        }

        public IEnumerable<Company> List()
        {
            return _context.Companies.ToList();
        }
    }
}
