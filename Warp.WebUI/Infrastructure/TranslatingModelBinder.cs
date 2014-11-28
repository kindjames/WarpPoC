using System;
using System.Web.Mvc;
using Warp.Core.Infrastructure.Models;

namespace Warp.WebUI.Infrastructure
{
    public class TranslatingModelBinder : DefaultModelBinder
    {
        private readonly ITextResourceModelProvider _textResourceModelProvider;

        public TranslatingModelBinder(ITextResourceModelProvider textResourceModelProvider)
        {
            _textResourceModelProvider = textResourceModelProvider;
        }

        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            _textResourceModelProvider.PopulateTextResourcesOnModel(bindingContext.Model);

            return base.BindModel(controllerContext, bindingContext);
        }
    }
}