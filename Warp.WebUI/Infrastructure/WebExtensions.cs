using System;
using System.Security.Claims;
using System.Security.Principal;
using System.Web.Mvc;
using FluentValidation;
using Warp.Core.Authentication;
using Warp.Core.Infrastructure.General;
using Warp.Core.Infrastructure.Util;
using Warp.Core.Services;

namespace Warp.WebUI.Infrastructure
{
    public static class WebExtensions
    {
        public static Guid GetCustomerId(this IPrincipal principal)
        {
            CheckArgument.NotNull(principal, "principal");
            CheckArgument.NotNull(principal.Identity, "principal.Identity");

            var id = principal.Identity.GetOrThrowClaimValueFor<string>(ApplicationClaimTypes.CustomerId);

            return Guid.Parse(id);
        }

        public static Guid GetUserId(this IPrincipal principal)
        {
            CheckArgument.NotNull(principal, "principal");
            CheckArgument.NotNull(principal.Identity, "principal.Identity");

            var id = principal.Identity.GetOrThrowClaimValueFor<string>(ClaimTypes.NameIdentifier);

            return Guid.Parse(id);
        }

        public static void AddValidationException(this ModelStateDictionary modelState, ValidationException exception)
        {
            foreach (var error in exception.Errors)
            {
                modelState.AddModelError(String.Empty, error.ErrorMessage);
            }
        }
    }
}