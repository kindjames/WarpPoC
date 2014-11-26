using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Owin.Security;
using SimpleInjector;
using SimpleInjector.Advanced;

namespace Warp.IoC.Factories
{
    internal sealed class AuthenticationManagerFactory
    {
        internal class FakeAuthenticationManager : IAuthenticationManager
        {
            public IEnumerable<AuthenticationDescription> GetAuthenticationTypes()
            {
                throw new NotImplementedException();
            }

            public IEnumerable<AuthenticationDescription> GetAuthenticationTypes(
                Func<AuthenticationDescription, bool> predicate)
            {
                throw new NotImplementedException();
            }

            public Task<AuthenticateResult> AuthenticateAsync(string authenticationType)
            {
                throw new NotImplementedException();
            }

            public Task<IEnumerable<AuthenticateResult>> AuthenticateAsync(string[] authenticationTypes)
            {
                throw new NotImplementedException();
            }

            public void Challenge(AuthenticationProperties properties, params string[] authenticationTypes)
            {
                throw new NotImplementedException();
            }

            public void Challenge(params string[] authenticationTypes)
            {
                throw new NotImplementedException();
            }

            public void SignIn(AuthenticationProperties properties, params ClaimsIdentity[] identities)
            {
                throw new NotImplementedException();
            }

            public void SignIn(params ClaimsIdentity[] identities)
            {
                throw new NotImplementedException();
            }

            public void SignOut(AuthenticationProperties properties, params string[] authenticationTypes)
            {
                throw new NotImplementedException();
            }

            public void SignOut(params string[] authenticationTypes)
            {
                throw new NotImplementedException();
            }

            public ClaimsPrincipal User { get; set; }
            public AuthenticationResponseChallenge AuthenticationResponseChallenge { get; set; }
            public AuthenticationResponseGrant AuthenticationResponseGrant { get; set; }
            public AuthenticationResponseRevoke AuthenticationResponseRevoke { get; set; }
        }

        public IAuthenticationManager Build(Container c)
        {
            try
            {
                return c.GetInstance<HttpContextBase>()
                    .GetOwinContext()
                    .Authentication;
            }
            catch (InvalidOperationException)
            {
                if (c.IsVerifying())
                {
                    return new FakeAuthenticationManager();
                }

                throw;
            }
        }
    }
}