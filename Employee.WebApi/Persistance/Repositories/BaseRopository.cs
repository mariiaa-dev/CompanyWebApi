using CompanyWebApi.Persistance.Contexts;

namespace CompanyWebApi.Persistance.Repositories
{
    public abstract class BaseRopository
    {
        protected readonly AppDbContext _context;

        public BaseRopository(AppDbContext context)
        {
            _context = context;
        }
    }
}
