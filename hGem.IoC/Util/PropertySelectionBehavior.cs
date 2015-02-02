using System;
using System.Linq;
using System.Reflection;
using SimpleInjector.Advanced;

namespace hGem.IoC.Util
{
    internal class PropertySelectionBehavior<TAttribute> : IPropertySelectionBehavior
        where TAttribute : Attribute
    {
        public bool SelectProperty(Type type, PropertyInfo prop)
        {
            return prop.GetCustomAttributes(typeof(TAttribute)).Any();
        }
    }
}