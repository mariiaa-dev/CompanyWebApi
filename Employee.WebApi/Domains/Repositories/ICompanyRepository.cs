using CompanyWebApi.Domains.Models;

namespace CompanyWebApi.Domains.Repositories
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> ListAsync();
    }
}
