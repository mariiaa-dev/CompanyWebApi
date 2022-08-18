using CompanyWebApi.Domains.Models;

namespace CompanyWebApi.Domains.Services
{
    public interface ICompanyService
    {
        Task<IEnumerable<Company>> ListAsync();
    }
}