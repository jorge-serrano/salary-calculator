using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jserrano.SalaryCalculator.Business.DependencyInjection
{
    using DataModel.Contracts;
    using Infrastructure.Repositories;
    using Unity;

    public class ServiceDependenciesResolver
    {
        public static void ResolveAllDependencies(IUnityContainer container)
        {
            container.RegisterType<IEmpRepository, EmpRepository>();
        }
    }
}
