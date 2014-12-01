using System.Web.Mvc;
using Warp.WebUI.Infrastructure;

namespace Warp.WebUI
{
    public partial class Startup
    {
        public void ConfigureModelBinders()
        {
            ModelBinders.Binders.DefaultBinder = DependencyResolver.Current.GetService<TranslatingModelBinder>();
        }
    }
}