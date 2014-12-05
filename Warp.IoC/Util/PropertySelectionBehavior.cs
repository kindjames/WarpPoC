using System;
using System.Linq;
using System.Reflection;
using SimpleInjector.Advanced;

namespace Warp.IoC
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