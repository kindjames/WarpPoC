using System;

namespace Warp.Core.Infrastructure.IoC
{
    /// <summary>
    /// Notifies IoC Container to perform Property-Injection.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public sealed class InjectDependencyAttribute : Attribute
    {
    }
}