using CompanyWebApi.Domeins.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyWebApi.Domeins.Services
{
    public interface ICompanyService
    {
        Task<IEnumerable<Company>> ListAsync();
    }
}