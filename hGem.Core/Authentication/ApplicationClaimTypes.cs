namespace hGem.Core.Authentication
{
    /// <summary>
    /// Contains the Uri's for custom Identity Claims.
    /// </summary>
    public static class ApplicationClaimTypes
    {
        public const string CustomerId = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/customerid";
        public const string RememberMe = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/rememberme";
    }
}