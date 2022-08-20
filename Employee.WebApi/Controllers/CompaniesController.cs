using AutoMapper;
using CompanyWebApi.Domains.Models;
using CompanyWebApi.Domains.Services;
using CompanyWebApi.Resources;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CompanyWebApi.Controllers
{
    [Route("/api/[controller]")]
    public class CompaniesController : Controller
    {
        private readonly ICompanyService _companyService;
        private readonly IMapper _mapper;

        public CompaniesController(ICompanyService companyService, IMapper mapper)
        {
            _companyService = companyService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CompanyResource>> GetAllAsync()
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;
            var companies = await _companyService.ListAsync(cancellationToken);
            var resources = _mapper.Map<List<Company>, IEnumerable<CompanyResource>>(companies);

            return resources;
        }
    }
}
