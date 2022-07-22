using CompanyWebApi.Domeins.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyWebApi.Domeins.Repositories
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> ListAsync();
    }
}
