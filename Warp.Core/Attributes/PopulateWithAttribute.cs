using System;

namespace Warp.Core.Attributes
{
    /// <summary>
    /// Populates the property with the specified text resource, translated into the user's language.
    /// </summary>
    public class PopulateWithAttribute : Attribute
    {
        public PopulateWithAttribute(int textResourceId)
        {
            TextResourceId = textResourceId;
        }

        public int TextResourceId { get; private set; }
    }
}
