using System;
using System.Reflection;

namespace Warp.Core.Exceptions.TextResources
{
    public sealed class SetterNotFoundOnModelException : Exception
    {
        public SetterNotFoundOnModelException(PropertyInfo propertyInfo)
            : base(BuildErrorMessage(propertyInfo))
        {
        }

        static string BuildErrorMessage(PropertyInfo propertyInfo)
        {
            return String.Concat("No setter found on property '", propertyInfo.Name, "' model when populating translated resource.");
        }
    }
}