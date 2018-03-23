namespace Jserrano.SalaryCalculator.Business.Factories
{
    using System;
    using System.CodeDom;
    using DataModel.Contracts;
    using Implementations;

    public class SalaryCalculatorFactory
	{
		public static ISalaryCalculator Create(string salaryType)
		{
		    switch (salaryType)
		    {
                case "HourlySalaryEmployee":
		            return new HourlySalaryEmployeeCalculator();
                case "MonthlySalaryEmployee":
		            return new MonthlySalaryEmployeeCalculator();
                default:
		            throw new NotSupportedException($"{salaryType} is not supported");
		    }
		}
	}
}
