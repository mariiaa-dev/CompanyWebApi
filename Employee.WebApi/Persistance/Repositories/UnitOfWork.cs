using CompanyWebApi.Domains.Repositories;
using CompanyWebApi.Persistance.Contexts;
using System.Threading;
using System.Threading.Tasks;

namespace CompanyWebApi.Persistance.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
