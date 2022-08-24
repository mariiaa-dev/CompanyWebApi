using CompanyWebApi.Resources;
using CompanyWebApi.Extensions;
using CompanyWebApi.Domains.Models;
using CompanyWebApi.Domains.Services;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using LoggerService.Interfaces;
using System;

namespace CompanyWebApi.Controllers
{
    [Route("/api/[controller]")]
    [Produces("application/json")]
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;
        private ILoggerManager _logger;

        public EmployeesController(IEmployeeService employeeService, IMapper mapper, ILoggerManager logger)
        {
            _employeeService = employeeService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<EmployeeResource>>> GetAsync()
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;

            _logger.LogInfo("Fetching all the Employees from the storage.");

            var employees = await _employeeService.ListAsync(cancellationToken);

            if (employees == null)
                throw new Exception("Exception while fetching all the employees from the storage.");

            var resources = _mapper.Map<List<Employee>, List<EmployeeResource>>(employees);

            _logger.LogInfo($"Returning {employees.Count} employees.");
            return resources;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveEmployeeResource resource)
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessage());
            }

            _logger.LogInfo("Adding Employee to the storage");

            var employee = _mapper.Map<SaveEmployeeResource, Employee>(resource);

            if (employee == null)
                throw new Exception("Exception while saving the employee to the storage.");

            var result = await _employeeService.SaveAsync(employee, cancellationToken);

            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            _logger.LogInfo($"Returning the employee: {employee}.");

            var employeeResource = _mapper.Map<Employee, EmployeeResource>(result.Employee);
            return Ok(employeeResource);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SaveEmployeeResource resource)
        {
            CancellationToken cancellationToken = HttpContext.RequestAborted;

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessage());
            }

            _logger.LogInfo("Updating Employee in the storage");

            var employee = _mapper.Map<SaveEmployeeResource, Employee>(resource);

            if (employee == null)
                throw new Exception("Exception while updating the employee in the storage.");

            var result = await _employeeService.UpdateAsync(id, employee, cancellationToken);

            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            var employeeResource = _mapper.Map<Employee, EmployeeResource>(result.Employee);

            _logger.LogInfo($"Returning the employee: {employee}.");

            return Ok(employeeResource);
        }
    }
}
