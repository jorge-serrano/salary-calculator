namespace Jserrano.SalaryCalculator.DataModel.Contracts
{
	using System;

	public interface ILogger
    {
	    void Info(string message);
        void Error(Exception exception);

    }
}
