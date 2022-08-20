using CompanyWebApi.Domains.Models;
using CompanyWebApi.Domains.Repositories;
using CompanyWebApi.Domains.Services;
using CompanyWebApi.Domains.Services.Communication;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CompanyWebApi.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IEmployeeRepository employeeRepository, IUnitOfWork unitOfWork)
        {
            _employeeRepository = employeeRepository;
            _unitOfWork = unitOfWork;
        }

        public Task<List<Employee>> ListAsync(CancellationToken cancellationToken)
        {
            return _employeeRepository.ListAsync(cancellationToken);
        }

        public async Task<SaveEmployeeResponse> SaveAsync(Employee employee)
        {
            try
            {
                 await _employeeRepository.AddAsync(employee);
                 await _unitOfWork.CompleteAsync();

                return new SaveEmployeeResponse(employee);
            }
            catch (Exception ex)
            {
                return new SaveEmployeeResponse($"An error occured when saving the employee: {ex.Message}");
            }
        }
    }
}
