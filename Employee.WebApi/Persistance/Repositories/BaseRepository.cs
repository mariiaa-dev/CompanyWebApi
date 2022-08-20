using CompanyWebApi.Persistance.Contexts;
using System.Threading;

namespace CompanyWebApi.Persistance.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
