using System;
using System.Linq;
using Warp.Core.Attributes;
using Warp.Core.Exceptions.TextResources;
using Warp.Core.Services;

namespace Warp.Core.Infrastructure.Models
{
    public sealed class TextResourceModelProvider : ITextResourceModelProvider
    {
        private readonly ITextResourceService _textResourceService;

        public TextResourceModelProvider(ITextResourceService textResourceService)
        {
            _textResourceService = textResourceService;
        }
        
        public object PopulateTextResourcesOnModel(object model)
        {
            // TODO: Cache reflection.
            // Get the properties to be translated.
            var propertyTypes = model.GetType()
                .GetProperties()
                .Where(p => p.IsDefined(typeof(PopulateWithAttribute), true));

            foreach (var propertyType in propertyTypes)
            {
                // Get attribute on property
                var textResourceAttribute = (PopulateWithAttribute)
                    Attribute.GetCustomAttribute(propertyType, typeof(PopulateWithAttribute));

                // Get textResource id from attribute.
                var textResourceId = textResourceAttribute.TextResourceId;

                // Get textResource from service.
                var textResource = _textResourceService.GetTextResource(textResourceId);

                if (String.IsNullOrEmpty(textResource))
                {
                    throw new TextResourceNotFoundException(textResourceId);
                }

                // Set property with translated text.
                var setterMethodType = propertyType.GetSetMethod();

                if (setterMethodType == null)
                {
                    throw new SetterNotFoundOnModelException(propertyType);
                }

                setterMethodType.Invoke(model, new object[] { textResource });
            }

            return model;
        }
    }
}