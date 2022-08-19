using CompanyWebApi.Domains.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyWebApi.Domains.Repositories
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> List();
    }
}
