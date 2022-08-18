using CompanyWebApi.Domains.Models;
using CompanyWebApi.Domains.Services.Communication;

namespace CompanyWebApi.Domains.Services.Communication
{
    public class SaveEmployeeResponse : BaseResponse
    {
        public Employee Employee { get; private set; }
        public SaveEmployeeResponse(bool succsess, string message, Employee employee) : base(succsess, message)
        {
            Employee = employee;
        }

        /// <summary>
        /// Create a sucsess response.
        /// </summary>
        /// <param name="employee">Save employee</param>
        /// <returns>Response.</returns>
        public SaveEmployeeResponse(Employee employee) : this(true, string.Empty, employee)
        { }

        /// <summary>
        /// Create an error response.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Response.</returns>
        public SaveEmployeeResponse(string message) : this(false, message, null)
        { }
    }
}
