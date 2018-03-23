namespace Jserrano.SalaryCalculator.Web.UI.Controllers.Api
{
	using System.Collections.Generic;
	using System.Web.Http;
	using DataModel.Contracts;
	using DataModel.DTOs;

	public class EmployeesController : ApiController
	{
	    private readonly IEmpService _service;
	    public EmployeesController(IEmpService service)
	    {
	        _service = service;
	    }

	    public IEnumerable<EmployeeInfo> Get()
	    {
	        return _service.GetAllEmployees();
	    }

        // GET api/values/5
        public IEnumerable<EmployeeInfo> Get(int id)
        {
            return new EmployeeInfo[] { _service.GetEmployeeById(id) };
        }
    }
}
