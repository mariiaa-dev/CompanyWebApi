using System.Threading.Tasks;

namespace CompanyWebApi.Domeins.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
