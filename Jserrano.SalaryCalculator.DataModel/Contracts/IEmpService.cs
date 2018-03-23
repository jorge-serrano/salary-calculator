namespace Jserrano.SalaryCalculator.DataModel.Contracts
{
	using System.Collections.Generic;
	using DTOs;

	public interface IEmpService
	{
		IEnumerable<EmployeeInfo> GetAllEmployees();

		EmployeeInfo GetEmployeeById(int Id);

	    IEnumerable<EmployeeInfo> CallEmpInternalApi(string apiUrl);
	}
}
