using System;
using hGem.Core.Infrastructure.Util;

namespace hGem.Core.Attributes
{
    /// <summary>
    /// Populates the property with the specified text resource, translated into the user's language.
    /// </summary>
    public class PopulateWithAttribute : Attribute
    {
        public PopulateWithAttribute(string textResourceIdentifierCode)
        {
            CheckArgument.NotEmpty(textResourceIdentifierCode, "textResourceIdentifierCode");
            TextResourceIdentifierCode = textResourceIdentifierCode;
        }

        public string TextResourceIdentifierCode { get; private set; }
    }
}