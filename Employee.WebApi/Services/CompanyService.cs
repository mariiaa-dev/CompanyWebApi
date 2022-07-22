using CompanyWebApi.Domeins.Models;
using CompanyWebApi.Domeins.Repositories;
using CompanyWebApi.Domeins.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyWebApi.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task<IEnumerable<Company>> ListAsync()
        {
            return await _companyRepository.ListAsync();
        }

/*        public async Task GetSalarySumAsync()
        {
            return await _companyRepository.
        }*/
    }
}
