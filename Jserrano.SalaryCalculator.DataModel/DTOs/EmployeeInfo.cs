namespace Jserrano.SalaryCalculator.DataModel.DTOs
{
	using System.ComponentModel;

	public class EmployeeInfo
    {

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

	    public double AnualSalary { get; set; }
	    public double BaseSalary { get; set; }

	    public string TypeOfSalary { get; set; }

    }
}
