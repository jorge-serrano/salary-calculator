namespace Jserrano.SalaryCalculator.DataModel.Contracts
{
	using System.Collections.Generic;
	using Models;

	public interface IEmpRepository
	{
		IEnumerable<Employee> GetAllEmployees();
		IEnumerable<Employee> GetEmployeeById(int id);

	    string ConnectionString { get; set; }
	}
}
