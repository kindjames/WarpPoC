using System;
using System.Web.Mvc;
using Warp.Core.Infrastructure.IoC;
using Warp.Core.Infrastructure.Models;

namespace Warp.WebUI.Infrastructure
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class PopulateTextResourcesOnModelAttribute : ActionFilterAttribute
    {
        [InjectDependency]
        public ITextResourceModelProvider TextResourceModelProvider { get; set; }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            if (filterContext.Controller.ViewData.Model != null)
            {
                if (TextResourceModelProvider == null)
                {
                    throw new InvalidOperationException("TextResourceModelProvider is null.");
                }

                TextResourceModelProvider.PopulateTextResourcesOnModel(filterContext.Controller.ViewData.Model);
            }

            base.OnResultExecuting(filterContext);
        }
    }
}