using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNet.Identity;

namespace Warp.Core.Infrastructure.Authentication
{
    public sealed class PasswordHasher : IPasswordHasher
    {
        public string HashPassword(string password)
        {
            var inputBytes = Encoding.UTF8.GetBytes(password + "reGucpbCPtWBgsFKfNtH");

            byte[] hashedBytes;

            using (var hashService = new SHA512CryptoServiceProvider())
            {
                hashedBytes = hashService.ComputeHash(inputBytes);
            }

            return BitConverter.ToString(hashedBytes)
                .Replace("-", "")
                .ToLower();
        }

        public PasswordVerificationResult VerifyHashedPassword(string hashedPassword, string providedPassword)
        {
            if (String.CompareOrdinal(hashedPassword, HashPassword(providedPassword)) == 0)
            {
                return PasswordVerificationResult.Success;
            }

            return PasswordVerificationResult.Failed;
        }
    }
}
