using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Owin.Security;

namespace Warp.IoC.Factories
{
    /// <summary>
    /// Allows DI registration of IAuthenticationManager from the ASP.NET Identity Framework.
    /// </summary>
    internal sealed class AuthenticationManagerFactory
    {
        private readonly HttpContextBase _httpContext;

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

        public AuthenticationManagerFactory(HttpContextBase httpContext)
        {
            _httpContext = httpContext;
        }
        
        /// <summary>
        /// If Build is called before OwinContext has been created, then will return a 
        /// FakeAuthenticationManager, otherwise return the IAuthenticationManager from 
        /// the Owin pipeline.
        /// </summary>
        /// <param name="isVerifying">Is the IoC Container currently verifying?</param>
        /// <returns></returns>
        public IAuthenticationManager Build(bool isVerifying)
        {
            try
            {
                return _httpContext
                    .GetOwinContext()
                    .Authentication;
            }
            catch (InvalidOperationException)
            {
                if (isVerifying)
                {
                    return new FakeAuthenticationManager();
                }

                throw;
            }
        }
    }
}