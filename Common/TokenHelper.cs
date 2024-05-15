using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace MessagingClient.Common
{
    public class TokenHelper
    {
        public static bool IsTokenExpired(string token)
        {
            // Initialize a JwtSecurityTokenHandler
            var tokenHandler = new JwtSecurityTokenHandler();

            try
            {
                // Try to parse the token
                var securityToken = tokenHandler.ReadToken(token) as JwtSecurityToken;

                // Check if the token has an expiration date
                if (securityToken?.ValidTo == null)
                {
                    // Token doesn't have an expiration date
                    return true;
                }

                // Check if the token is expired
                var now = DateTime.UtcNow;
                var expires = securityToken.ValidTo;
                return now >= expires;
            }
            catch (Exception ex)
            {
                // Token couldn't be parsed
                Console.WriteLine($"Token validation failed: {ex.Message}");
                return true;
            }
        }
    }
}