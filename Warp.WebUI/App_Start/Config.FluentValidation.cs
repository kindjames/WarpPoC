using FluentValidation.Mvc;
using Warp.WebUI.Infrastructure;

namespace Warp.WebUI
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