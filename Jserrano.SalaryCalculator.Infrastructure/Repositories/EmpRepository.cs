using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jserrano.SalaryCalculator.Infrastructure.Repositories
{
    using DataModel.Contracts;
    using DataModel.Models;
    using Web;

    public class EmpRepository:IEmpRepository
    {
        public IEnumerable<Employee> GetAllEmployees()
        {
            return Task.Run(() => WebApiClient<Employee>.GetModelFromApi(ConnectionString)).GetAwaiter().GetResult();
        }

        public IEnumerable<Employee> GetEmployeeById(int id)
        {
            return GetAllEmployees().Where(e => e.id == id);
        }

        public string ConnectionString { get; set; }
    }
}
