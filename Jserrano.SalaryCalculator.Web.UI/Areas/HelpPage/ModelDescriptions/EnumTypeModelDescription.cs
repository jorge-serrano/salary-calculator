namespace Jserrano.SalaryCalculator.Web.UI.Areas.HelpPage.ModelDescriptions
{
	using System.Collections.ObjectModel;

	public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}