namespace Jserrano.SalaryCalculator.Business.Implementations
{
    using DataModel.Contracts;
    using DataModel.Models;

    public class MonthlySalaryEmployeeCalculator : ISalaryCalculator
    {
        public double Calculate(Employee empInfo)
        {
            return empInfo.monthlySalary*12;
        }
    }
}