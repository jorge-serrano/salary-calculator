namespace Jserrano.SalaryCalculator.Web.UI.Controllers
{
	using System;
	using System.Collections.Generic;
	using System.Drawing.Text;
	using System.Net.Http;
	using System.Threading.Tasks;
	using System.Web.Http;
	using System.Web.Mvc;
	using DataModel.Contracts;
	using DataModel.DTOs;

	public class HomeController : Controller
	{
	    private readonly IEmpService _service;
	    public HomeController(IEmpService service)
	    {
	        _service = service;
	    }

	    public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public async Task<ActionResult> GetEmployees([FromBody] string IdEmp)
        {
            IEnumerable<EmployeeInfo> employees = new List<EmployeeInfo>();
            string apiUrl = Request.Url.AbsoluteUri.Replace(Request.Url.AbsolutePath, "") + "/api/Employees";
            if (!string.IsNullOrEmpty(IdEmp))
            {
	            apiUrl += $"/{IdEmp}";
            }

            employees = await GetValue(apiUrl);

            return View(employees);
        }

		private  async Task<IEnumerable<EmployeeInfo>> GetValue(string apiUrl)
		{
             return  _service.CallEmpInternalApi(apiUrl);
		}
    }
}
