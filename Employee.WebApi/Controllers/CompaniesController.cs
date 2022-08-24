using AutoMapper;
using CompanyWebApi.Domains.Models;
using CompanyWebApi.Domains.Services;
using CompanyWebApi.Resources;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System;
using LoggerService.Interfaces;

namespace CompanyWebApi.Controllers
{
    [Route("/api/[controller]")]
    public class CompaniesController : Controller
    {
        private readonly ICompanyService _companyService;
        private readonly IMapper _mapper;
        private ILoggerManager _logger;

        public CompaniesController(ICompanyService companyService, IMapper mapper, ILoggerManager logger)
        {
            _companyService = companyService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<CompanyResource>>> GetAllAsync()
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;

            _logger.LogInfo("Fetching all the Companies from the storage");

            var companies = await _companyService.ListAsync(cancellationToken);

            if (companies == null)
                throw new Exception("Exception while fetching all the companies from the storage.");

            var resources = _mapper.Map<List<Company>, List<CompanyResource>>(companies);

            _logger.LogInfo($"Returning {companies.Count} companies.");
            return resources;
        }
    }
}
