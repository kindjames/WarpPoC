using System;
using System.Web.Mvc;
using FluentValidation;
using Warp.IoC;

namespace Warp.WebUI
{
    public partial class Startup
    {
        public static void ConfigureIocBindings()
        {
            DependencyResolver.SetResolver(CompositionRoot.GetFullyRegisteredContainer());
        }
    }
}