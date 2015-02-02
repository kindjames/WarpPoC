﻿using System;
using System.Globalization;
using System.Security.Claims;
using System.Security.Principal;
using hGem.Core.Exceptions.User;
using Microsoft.AspNet.Identity;

namespace hGem.Core.Authentication
{
    public static class IdentityExtensions
    {
        public static T GetClaimValueFor<T>(this IIdentity identity, string claimType) where T : IConvertible
        {
            if (identity == null)
            {
                throw new ArgumentNullException("identity");
            }

            var ci = identity as ClaimsIdentity;

            if (ci != null)
            {
                var id = ci.FindFirstValue(claimType);

                if (id != null)
                {
                    return (T)Convert.ChangeType(id, typeof(T), CultureInfo.InvariantCulture);
                }
            }

            return default(T);
        }

        public static T GetOrThrowClaimValueFor<T>(this IIdentity identity, string claimType) where T : IConvertible
        {
            var value = identity.GetClaimValueFor<T>(claimType);

            if (value == null)
            {
                throw new ClaimNotFoundOnIdentityException(claimType);
            }

            return value;
        }
    }
}