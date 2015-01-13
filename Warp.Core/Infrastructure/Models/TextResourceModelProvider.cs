using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Warp.Core.Attributes;
using Warp.Core.Exceptions.TextResources;
using Warp.Core.Services.TextResourceService;

namespace Warp.Core.Infrastructure.Models
{
    public sealed class TextResourceModelProvider : ITextResourceModelProvider
    {
        private readonly static ConcurrentDictionary<Type, IEnumerable<PropertyInfo>> CachedModelProperties;
        private readonly ITextResourceService _textResourceService;

        static TextResourceModelProvider()
        {
            CachedModelProperties = new ConcurrentDictionary<Type, IEnumerable<PropertyInfo>>();
        }

        public TextResourceModelProvider(ITextResourceService textResourceService)
        {
            _textResourceService = textResourceService;
        }
        
        public object PopulateTextResourcesOnModel(object model)
        {
            var modelType = model.GetType();

            // Get properties from either cache or invoking reflection.
            var propertyTypes = CachedModelProperties.GetOrAdd(modelType,
                t => t.GetProperties().Where(p => p.IsDefined(typeof(PopulateWithAttribute), true)));

            foreach (var propertyType in propertyTypes)
            {
                // Get attribute on property
                var textResourceAttribute = (PopulateWithAttribute)
                    Attribute.GetCustomAttribute(propertyType, typeof(PopulateWithAttribute));

                // Get textResource id from attribute.
                var textResourceId = textResourceAttribute.TextResourceId;
                //var userLanguageId = new GetDefaultLanguageForUserQueryHandler { };

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