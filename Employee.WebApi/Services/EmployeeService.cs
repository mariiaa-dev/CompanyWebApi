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

        public async Task<SaveEmployeeResponse> SaveAsync(Employee employee, CancellationToken cancellationToken)
        {
            try
            {
                _employeeRepository.AddAsync(employee);
                await _unitOfWork.CompleteAsync(cancellationToken);

                return new SaveEmployeeResponse(employee);
            }
            catch (Exception ex)
            {
                return new SaveEmployeeResponse($"An error occured when saving the employee: {ex.InnerException.Message}");
            }
        }

        public async Task<SaveEmployeeResponse> UpdateAsync(int id, Employee employee, CancellationToken cancellationToken)
        {
            var existingEmployee = await _employeeRepository.FindEmployeeById(id, cancellationToken);

            if (existingEmployee == null)
            {
                return new SaveEmployeeResponse("Employee not found");
            }

            existingEmployee.Name = employee.Name;
            existingEmployee.Surname = employee.Surname;
            existingEmployee.CompanyId = employee.CompanyId;
            existingEmployee.EmploymentDate = employee.EmploymentDate;
            existingEmployee.PositionId = employee.PositionId;
            existingEmployee.Salary = employee.Salary;
            existingEmployee.Mail = employee.Mail;

            try
            {
                _employeeRepository.Update(existingEmployee);
                await _unitOfWork.CompleteAsync(cancellationToken);

                return new SaveEmployeeResponse(existingEmployee);
            }
            catch (Exception ex)
            {
                return new SaveEmployeeResponse($"An error occurred when updating the employee: {ex.InnerException.Message}");
            }
        }
    }
}
