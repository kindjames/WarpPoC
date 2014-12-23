using System;

namespace Warp.Core.Infrastructure.IoC
{
    /// <summary>
    /// Notifies IoC Container to perform Property-Injection.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class InjectDependencyAttribute : Attribute
    {
    }
}