using FluentValidation.Mvc;
using hGem.WebUI.Infrastructure;

namespace hGem.WebUI
{
    public partial class Startup
    {
        public static void ConfigureFluentValidation()
        {
            FluentValidationModelValidatorProvider.Configure(provider =>
            {
                provider.ValidatorFactory = new FluentValidatorFactory();
            });
        }
    }
}