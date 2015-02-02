using System;
using System.Web.Mvc;

namespace hGem.WebUI.Infrastructure
{
    public sealed class RequiredRolesAttribute : AuthorizeAttribute
    {
        public RequiredRolesAttribute(params string[] roleNames)
        {
            Roles = String.Join(", ", roleNames);
        }
    }
}