﻿using System;
using System.Web.Mvc;
using hGem.Core.Infrastructure.IoC;
using hGem.Core.Infrastructure.Models;

namespace hGem.WebUI.Infrastructure
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
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