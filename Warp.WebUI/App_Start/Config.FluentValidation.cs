using FluentValidation.Mvc;

namespace Warp.WebUI
{
    public partial class Startup
    {
        public static void ConfigureFluentValidation()
        {
            FluentValidationModelValidatorProvider.Configure();
        }
    }
}