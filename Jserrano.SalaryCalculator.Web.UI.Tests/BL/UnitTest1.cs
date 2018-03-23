using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jserrano.SalaryCalculator.Web.UI.Tests.BL
{
    using System.Web.UI.WebControls;
    using Business.Factories;
    using Business.Implementations;
    using DataModel.Contracts;

    [TestClass]
    public class SalaryCalculatorFactoryTest
    {
        [TestMethod]
        public void TestInstanceCreationForHourly()
        {
            var salaryType = "HourlySalaryEmployee";
            ISalaryCalculator instance = 
                SalaryCalculatorFactory.Create(salaryType);
            Assert.IsInstanceOfType(instance,typeof(HourlySalaryEmployeeCalculator));
        }
        [TestMethod]
        public void TestInstanceCreationForMonthly()
        {
            var salaryType = "MonthlySalaryEmployee";
            ISalaryCalculator instance =
                SalaryCalculatorFactory.Create(salaryType);
            Assert.IsInstanceOfType(instance, typeof(MonthlySalaryEmployeeCalculator));
        }
    }
}
