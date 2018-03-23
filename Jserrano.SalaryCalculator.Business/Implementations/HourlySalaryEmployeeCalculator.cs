namespace Jserrano.SalaryCalculator.Business.Implementations
{
    using DataModel.Contracts;
    using DataModel.Models;

    public class HourlySalaryEmployeeCalculator : ISalaryCalculator
    {
        public double Calculate(Employee empInfo)
        {
            return empInfo.hourlySalary*120*12;
        }
    }
}