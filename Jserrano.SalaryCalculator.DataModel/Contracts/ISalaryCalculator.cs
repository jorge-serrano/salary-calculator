namespace Jserrano.SalaryCalculator.DataModel.Contracts
{
    using Models;

    public interface ISalaryCalculator
    {
        double Calculate(Employee empInfo);
    }
}
