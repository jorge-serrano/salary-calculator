namespace Jserrano.SalaryCalculator.Web.UI.Areas.HelpPage.ModelDescriptions
{
	using System.Collections.ObjectModel;

	public class ComplexTypeModelDescription : ModelDescription
    {
        public ComplexTypeModelDescription()
        {
            Properties = new Collection<ParameterDescription>();
        }

        public Collection<ParameterDescription> Properties { get; private set; }
    }
}