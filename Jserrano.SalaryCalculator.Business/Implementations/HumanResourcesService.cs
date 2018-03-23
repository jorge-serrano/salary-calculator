using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jserrano.SalaryCalculator.Business.Implementations
{
    using System.Configuration;
    using DataModel.Contracts;
    using DataModel.DTOs;
    using DataModel.Models;
    using Factories;
    using Infrastructure.Web;

    public class HumanResourcesService : IEmpService
    {
        private readonly IEmpRepository _repository;
        private readonly List<EmployeeInfo> _dtoEmployeeInfo;
        public HumanResourcesService(IEmpRepository repository)
        {
            _repository = repository;
            _repository.ConnectionString = ConfigurationManager.AppSettings["externalApi.Url"];
            _dtoEmployeeInfo = new List<EmployeeInfo>();
        }

        public IEnumerable<EmployeeInfo> GetAllEmployees()
        {
            IEnumerable<Employee> employees = _repository.GetAllEmployees();
            foreach (var employee in employees)
            {
                _dtoEmployeeInfo.Add(GetAtributes(employee));
            }
            return _dtoEmployeeInfo;
        }

        private EmployeeInfo GetAtributes(Employee employee)
        {
            var calculator = SalaryCalculatorFactory.Create(employee.contractTypeName);
            return new EmployeeInfo()
            {
                EmployeeId = employee.id,
                BaseSalary = employee.hourlySalary,
                AnualSalary = calculator.Calculate(employee),
                EmployeeName = employee.name,
                TypeOfSalary = employee.contractTypeName
            };
        }

        public EmployeeInfo GetEmployeeById(int Id)
        {
            Employee employee = _repository.GetEmployeeById(Id).FirstOrDefault();
            return GetAtributes(employee);
        }

        public IEnumerable<EmployeeInfo> CallEmpInternalApi(string apiUrl)
        {
           return Task.Run(() => WebApiClient<EmployeeInfo>.GetModelFromApi(apiUrl)).GetAwaiter().GetResult();
        }
    }
}
