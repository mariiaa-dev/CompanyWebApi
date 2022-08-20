using CompanyWebApi.Domains.Models;
using CompanyWebApi.Domains.Repositories;
using CompanyWebApi.Domains.Services;
using System.Collections.Generic;
using System.Threading;
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

        public Task<List<Company>> ListAsync(CancellationToken cancellationToken)
        {
            return _companyRepository.ListAsync(cancellationToken);
        }
    }
}
