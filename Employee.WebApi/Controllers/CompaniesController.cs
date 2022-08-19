using AutoMapper;
using CompanyWebApi.Domains.Models;
using CompanyWebApi.Domains.Services;
using CompanyWebApi.Resources;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public IEnumerable<CompanyResource> GetAllAsync()
        {
            var companies = _companyService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Company>, IEnumerable<CompanyResource>>(companies);
            return resources;
        }
    }
}
