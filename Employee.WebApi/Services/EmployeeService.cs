using CompanyWebApi.Domeins.Models;
using CompanyWebApi.Domeins.Repositories;
using CompanyWebApi.Domeins.Services;
using CompanyWebApi.Domeins.Services.Communication;
using System;
using System.Collections.Generic;
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

        public async Task<IEnumerable<Employee>> ListAsync()
        {
            return await _employeeRepository.ListAsync();
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

/*        public async Task<decimal> GetSalarySumByCompany(Company company)
        {
            if(company.MounthlyBudget < _employeeRepository.GetSalarySumByCompany(company.Id))
        }*/
    }
}
