namespace Jserrano.SalaryCalculator.Web.UI.Tests.Controllers
{
	using System.Web.Mvc;
	using DataModel.Contracts;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using UI.Controllers;

	[TestClass]
    public class HomeControllerTest
	{
	    private IEmpService _service;
	    private IEmpRepository _repository ;

	    public HomeControllerTest(IEmpRepository repository, IEmpService service)
	    {
	        _repository = repository;
	        _service = service;
	    }

	    [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController(_service);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            
        }
    }
}
