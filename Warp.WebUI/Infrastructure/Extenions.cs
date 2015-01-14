using System;
using System.Security.Claims;
using System.Security.Principal;
using System.Web.Mvc;
using Warp.Core.Authentication;
using Warp.Core.Services;
using Warp.Core.Util;

namespace Warp.WebUI.Infrastructure
{
    public static class WebExtensions
    {
        public static int GetCustomerId(this IPrincipal principal)
        {
            CheckArgument.NotNull(principal, "principal");
            CheckArgument.NotNull(principal.Identity, "principal.Identity");

            return principal.Identity.GetOrThrowClaimValueFor<int>(ApplicationClaimTypes.CustomerId);
        }

        public static int GetUserId(this IPrincipal principal)
        {
            CheckArgument.NotNull(principal, "principal");
            CheckArgument.NotNull(principal.Identity, "principal.Identity");

            return principal.Identity.GetOrThrowClaimValueFor<int>(ClaimTypes.NameIdentifier);
        }

        public static void AddErrorsFromResponse(this ModelStateDictionary modelState, IResponse response)
        {
            foreach (var error in response.Messages)
            {
                modelState.AddModelError(String.Empty, error);
            }
        }
    }
}